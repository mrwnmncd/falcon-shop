using System.Text.Json;

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

    public Product? FindProduct(string id) {
        return Inventory.FirstOrDefault(p => p?.Id == id);
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
        List<InventoryItem> items = cart.Items;
        
        string transactionParticulars = "";
        
        foreach (Product item in items) {
            Product? product = FindProduct(item.Id);
            if (product is null) return false;

            foreach (InventoryItem? inventoryItem in Inventory)
                if (inventoryItem?.Id == product.Id) {
                    if (inventoryItem.Quantity == 0) return false;
                    inventoryItem.Quantity -= 1;
                }
        }
        
        string transactionId = Guid.NewGuid().ToString();
         JsonSerializer.Serialize(new {
            Id = transactionId,
            Account = account,
            Items = items,
            Date = DateTime.Now
        });

        return null;
    }
}