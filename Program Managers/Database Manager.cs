using Microsoft.Data.Sqlite;
using App.Environment;

namespace App.API;

public partial class Database {
    private readonly SqliteConnection _connection;
    private string? _table { get; set; } = null;

    public Database(string database) {
        _connection = new SqliteConnection($"Data Source={database}");
        _connection.Open();
    }

    public Database SetTable(string table) {
        _table = table;
        return this;
    }

    public string? LookupEntry(string column, string key) {
        ValidateObject();
        string query = $"SELECT * FROM {_table} WHERE {column} = '{key}'";
        using var command = new SqliteCommand(query, _connection);
        var reader = command.ExecuteReader();
        reader.Read();
        if (!reader.HasRows) return null;
        string[] values = new string[reader.FieldCount];
        reader.GetValues(values);
        return values[0];
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
        string query = columns is null
            ? $"INSERT INTO {_table} VALUES ({values})"
            : $"INSERT INTO {_table} ({columns}) VALUES ({values})";
        using var command = new SqliteCommand(query, _connection);
        return command.ExecuteNonQuery() > 0;
    }

    public void Close() {
        _connection.Close();
    }
}

public partial class Database {
    private void ValidateObject() {
        if (_table is null) throw new Exception("Table not set");
    }
}