using Microsoft.Data.Sqlite;

using App.Environment;

namespace App.API;

public class Database {
    private readonly SqliteConnection _connection = new SqliteConnection($"Data Source={Constants.DatabaseUrl}");
    private readonly string _table;

    public Database(string table) {
        _table = table;
        _connection.Open();
    }

    public string LookupEntry(string key, string value) {
        string query = $"SELECT * FROM {_table} WHERE {key} = '{value}'";
        using var command = new SqliteCommand(query, _connection);
        var reader = command.ExecuteReader();
        reader.Read();
        return reader.GetString(0);
    }
    
    public bool DeleteEntry(string key, string value) {
        string query = $"DELETE FROM {_table} WHERE {key} = '{value}'";
        using var command = new SqliteCommand(query, _connection);
        return command.ExecuteNonQuery() > 0;
    }
    
    public string ModifyEntry(string key, string value, string newValue) {
        string query = $"UPDATE {_table} SET {key} = '{newValue}' WHERE {key} = '{value}'";
        using var command = new SqliteCommand(query, _connection);
        return command.ExecuteNonQuery() > 0 ? newValue : "";
    }
    
    public bool AddEntry(string values, string? columns = null) {
        string query = columns is null ? $"INSERT INTO {_table} VALUES ({values})" : $"INSERT INTO {_table} ({columns}) VALUES ({values})";
        using var command = new SqliteCommand(query, _connection);
        return command.ExecuteNonQuery() > 0;
    }

    public void Close() {
        _connection.Close();
    }
}