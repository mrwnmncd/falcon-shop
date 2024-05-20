/*
    GUI:            User Signup, User Login
    UI DESIGNER:    JM Palsis (Sign Up)
                    Mharwin Moncada (Login)

    GRAPHICAL USER INTERFACE (GUI) DESIGN
    Form Name:      Signup
    View For:       Customer

    GRAPHICAL USER INTERFACE (GUI) DESIGN
    Form Name:      Login
    View For:       Customer
*/


using System;
using System.IO;
using System.Linq;
using App.API;
using Microsoft.Data.Sqlite;
using App.Environment;

namespace App.Models;

public class Account : User {
    public string Email { get; set; } = "";
    public string Username { get; set; } = "";
    public string Password { get; set; } = "";
    
    public Account() { }

    public dynamic Register() {
        if (Validate(this) is false) throw new Exception("Invalid account details");

        SqliteConnection connection = new SqliteConnection($"Data Source={Constants.DatabaseUrl}");

        connection.Open();
        {
            string lookupQuery = $"SELECT * FROM Accounts WHERE Username = '{Username}'";
            using var command = new SqliteCommand(lookupQuery, connection);
            var reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows) return false;
        }

        {
            string insertAccountQuery = $"INSERT INTO Accounts VALUES ('{Id}', '{Username}', '{Password}', '{Email}')";
            string insertUserQuery = $"INSERT INTO Users VALUES ('{Id}', '{Type}', '{Forename}', '{MiddleName}', '{Surname}')";
            using var accountCommand = new SqliteCommand(insertAccountQuery, connection);
            accountCommand.ExecuteNonQuery();   
            using var userCommand = new SqliteCommand(insertUserQuery, connection);
            userCommand.ExecuteNonQuery();
        }
        return this;
    }

    public static Account? Login(string username, string password) {
        Account? user = Lookup(username);
        // TODO: allow lookup with id
        if (user.Password != password) return null;
        return user;
    }

    public static Account? Lookup(string username) {
        SqliteConnection connection = new SqliteConnection($"Data Source={Constants.DatabaseUrl}");
        connection.Open();
        {
            string accountQuery = $"SELECT * FROM Accounts WHERE Username = '{username}'";
            string userQuery =
                $"SELECT * FROM Users WHERE Id = (SELECT Id FROM Accounts WHERE Username = '{username}')";
            using var accountCommand = new SqliteCommand(accountQuery, connection);
            var accountReader = accountCommand.ExecuteReader();
            using var userCommand = new SqliteCommand(userQuery, connection);
            var userReader = userCommand.ExecuteReader();
            accountReader.Read();
            userReader.Read();
            if (accountReader.GetString(0) is null) return null;
            Account account = new Account() {
                Id = accountReader.GetString(0) ?? "",
                Username = accountReader.GetString(1) ?? "",
                Password = accountReader.GetString(2) ?? "",
                Email = accountReader.GetString(3) ?? "",

                Type = userReader.GetString(1) ?? "",
                Forename = userReader.GetString(2) ?? "",
                MiddleName = userReader.GetString(3) ?? "",
                Surname = userReader.GetString(4) ?? ""
            };
            return account;
        }
    }

    private static bool Validate(Account account) {
        if (string.IsNullOrEmpty(account.Id)) return false;
        if (string.IsNullOrEmpty(account.Type)) return false;
        if (string.IsNullOrEmpty(account.Forename) || string.IsNullOrEmpty(account.Surname)) return false;
        if (string.IsNullOrEmpty(account.Username) || string.IsNullOrEmpty(account.Password)) return false;
        return true;
    }
}