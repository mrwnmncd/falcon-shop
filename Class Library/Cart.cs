/*
    GUI:            Checkout, Shop Products
    UI DESIGNER:    Yssa Clarisse Pasia (Checkout)
                    Sean David Vallespin (Shop Products)

    GRAPHICAL USER INTERFACE (GUI) DESIGN
    Form Name:      Checkout
    View For:       Customer

    GRAPHICAL USER INTERFACE (GUI) DESIGN
    Form Name:      Products
    View For:       Customer
*/


using System;
using System.Linq;
using System.Text.Json;

namespace App.Models;

public class Cart(Account account, Store store) {
    public Account Account { get; set; } = account ?? throw new ArgumentNullException(nameof(account));
    public List<InventoryItem> Items = [];

    public InventoryItem? AddProduct(Product product, int quantity = 1) {
        ArgumentNullException.ThrowIfNull(product);
        if (product.Id == null) throw new ArgumentNullException(nameof(product.Id) + " is required.");

        Product? item = store.FindProduct(product.Id);
        if (item is null) return null;
        
        InventoryItem cartItem = new() {
            Id = item.Id,
            Name = item.Name,
            Description = item.Description,
            Price = item.Price,
            Specifications = item.Specifications,
            Type = item.Type,
            Quantity = quantity
        };

        foreach (InventoryItem punch in Items) {
            if (punch.Id != cartItem.Id) continue;
            punch.Quantity += quantity;
            return punch;
        }

        Items.Add(cartItem);
        return cartItem;
    }

    public bool RemoveFromCart(Product product) {
        Product? item = store.FindProduct(product.Id);
        if (item is null) return false;
        
        InventoryItem? cartItem = Items.Find(p => p.Id == item.Id);

        Items.Remove(cartItem);
        return true;
    }

    public double TotalPrice() {
        return Items.Sum(p => p.Price * p.Quantity);
    }
    
    
}
