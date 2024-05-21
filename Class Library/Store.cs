using System.Text.Json;
using System.Transactions;
using Microsoft.Data.Sqlite;
using App.Testing;

namespace App.Models;

public class Store {
    public List<InventoryItem?> Inventory { get; set; } = [];

    public Store() { }

    public bool AddProduct(InventoryItem product) {
        if (product.Id == null) throw new ArgumentNullException(nameof(product.Id) + " is required.");
        if (product.Name == null) throw new ArgumentNullException(nameof(product.Name) + " is required.");
        if (product.Description == null) throw new ArgumentNullException(nameof(product.Description) + " is required.");
        if (product.Price == null) throw new ArgumentNullException(nameof(product.Price) + " is required.");
        if (product.Quantity == null) throw new ArgumentNullException(nameof(product.Quantity) + " is required.");
        if (product.Specifications != null) { }

        ArgumentNullException.ThrowIfNull(product);
        Inventory.Add(product);
        return true;
    }

    public bool RemoveProduct(InventoryItem product) {
        ArgumentNullException.ThrowIfNull(product);
        Inventory.Remove(product);
        return true;
    }

    public Product? FindProductById(string id) {
        Product? product = null;
        foreach (Models.Product item in Inventory) {
            if (item?.Id != id) continue;
            product = item;
            break;
        }

        return product;
    }

    public Product? FindProductByName(string name) {
        Product? product = null;
        foreach (var item in Inventory) {
            if (item?.Name != name) continue;
            product = item;
            break;
        }

        return product;
    }

    public dynamic RecordTransaction(Cart cart) {
        /*
         * 1. Get the Cart
         * 2. From the cart, get the Account
         * 3. From the cart, get the Items
         * 4. For each Item, reduce the Quantity from the Store
         * 5. Record the Transaction
         * 6. Send the Transaction to Database
         * 7. Return the Transaction
         */

        Account account = cart.Account;

        foreach (Product item in cart.Items) {
            Product? product = FindProductById(item.Id);

            if (product is null) return false;

            foreach (InventoryItem? inventoryItem in Inventory)
                if (inventoryItem?.Id == product.Id) {
                    Console.WriteLine(inventoryItem.Name + " " + inventoryItem.Quantity);
                    if (inventoryItem.Quantity == 0) return false;
                    inventoryItem.Quantity -= 1;
                }
        }

        string transactionParticulars = JsonSerializer.Serialize(cart.Items);
        Snowflake idGenerator = new Snowflake(0, 0);
        string transactionId = idGenerator.CreateId().ToString();
        transactionId = transactionId.Substring(transactionId.Length - 6);
        string transaction = JsonSerializer.Serialize(new {
            Id = transactionId,
            Account = account,
            Items = transactionParticulars,
            Date = DateTime.Now
        });

        SqliteConnection connection = new SqliteConnection($"Data Source={App.Environment.Constants.DatabaseUrl}");
        connection.Open();
        {
            string lookupQuery = $"SELECT * FROM Transactions WHERE Id = '{transactionId}'";
            using var command = new SqliteCommand(lookupQuery, connection);
            var reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows) return false;
        }
        {
            string insertTransactionQuery = $"INSERT INTO Transactions VALUES ('{transactionId}', '{transaction}')";
            using var accountCommand = new SqliteCommand(insertTransactionQuery, connection);
            accountCommand.ExecuteNonQuery();
        }

        return transactionId;
    }
}