using System;
using System.Collections.Generic;
using App.Models;

namespace App;

public class Client {
    public bool Simulating { get; }

    // ReSharper disable once InconsistentNaming
    public readonly UI UI;
    public readonly User User;
    public readonly Store Store = new();

    public Client(bool simulating = false) {
        User = new User(this);
        UI = new UI(this);
        Simulating = simulating;

        if (Simulating) {
            Testing.SimulationUtilities.Login(this);
            Utilities.Testing.Shop.LoadProducts(Store);
            Testing.SimulationUtilities.AddToCart(this);
        }
    }

    public void Exit() {
        Console.WriteLine("PROGRAM [CLIENT] EXIT");
        if (System.Windows.Forms.Application.MessageLoop)
            System.Windows.Forms.Application.Exit();
        else System.Environment.Exit(1);
    }
}

public class User(Client client) {
    public bool IsLoggedIn => Account is not null;
    public Account? Account;
    public Cart? Cart;

    public bool Login(string username, string password) {
        Account? login = Account.Login(username, password);
        if (login is null) return false;
        Account = login;
        Cart = new Cart(Account, client.Store);
        Console.WriteLine($"PROGRAM [CLIENT] LOGIN: {Account?.Username}:{Account?.Password}");
        Console.WriteLine("    " + $"{Account?.Id} {Account?.Username} {Account?.FullName}");

        return true;
    }

    public void Logout() {
        Account = null;
        Cart = null;
    }
}

// ReSharper disable once InconsistentNaming
public class UI(Client client) {
    public readonly App.GUI.Splash Splash = new App.GUI.Splash(client);
    public readonly App.GUI.Login Login = new App.GUI.Login(client);
    public readonly App.GUI.SignUp SignUp = new App.GUI.SignUp(client);
    public readonly App.GUI.StudentHome StudentHome = new App.GUI.StudentHome(client);
    public readonly App.GUI.StaffHome StaffHome = new App.GUI.StaffHome(client);
    public readonly App.GUI.ShopItems ShopItems = new App.GUI.ShopItems(client);
    public readonly App.GUI.Cart Cart = new App.GUI.Cart(client);
    public readonly App.GUI.Checkout Checkout = new App.GUI.Checkout(client);

    public readonly App.GUI.Receipt Receipt = new App.GUI.Receipt(client);

    // public readonly App.GUI.Orders Orders = new App.GUI.Orders(client);
    public readonly App.GUI.Inventory Inventory = new App.GUI.Inventory(client);
}