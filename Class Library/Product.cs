/*
    GUI:            Shop Products
    UI DESIGNER:    Sean David Vallespin

    GRAPHICAL USER INTERFACE (GUI) DESIGN
    Form Name:      Products
    View For:       Customer
*/


using System;
using System.Collections.Generic;

namespace App.Models;

public class Product
{
    public string Id { get; set; } = "";  
    public string Name { get; set; } = ""; 
    public string Description { get; set; } = ""; 
    public double Price { get; set; } 

    public Dictionary<string, dynamic>? Specifications { get; set; } = new() {
        { "Size", "" },
        { "Color", "" },
        { "Type", "" },
        { "Variants", Array.Empty<string>() }
    };

    public string? Type { get; set; }
}

public class InventoryItem : Product
{
    public int Quantity { get; set; } = 0;
}