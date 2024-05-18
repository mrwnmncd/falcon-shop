using System;
using System.Collections.Generic;

using App.Models;

namespace App;

public class Client {

    public bool Simulating { get; }

    
    public readonly UI UI;
    public readonly User User;
    public Store Store = new();
    public Client(bool simulating = false) {
        User = new User(this);
        UI = new UI(this);
        Simulating = simulating;
        
        if (Simulating) {
            App.Testing.SimulationUtilities.Login(this);
            App.Testing.ShopUtilities.LoadProducts(Store);
        }
    }
    
    public void LoadStoreProducts() {
        App.Testing.ShopUtilities.LoadProducts(Store);
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
}

// ReSharper disable once InconsistentNaming
public class UI(Client client) {
    public readonly App.GUI.Splash Splash = new App.GUI.Splash(client);
    public readonly App.GUI.Login Login = new App.GUI.Login(client);
    public readonly App.GUI.SignUp SignUp = new App.GUI.SignUp(client);
    public readonly App.GUI.Home Home = new App.GUI.Home(client);
    public readonly App.GUI.Products Products = new App.GUI.Products(client);
    public readonly App.GUI.Cart Cart = new App.GUI.Cart(client);
    public readonly App.GUI.Checkout Checkout = new App.GUI.Checkout(client);
    public readonly App.GUI.Inventory Inventory = new App.GUI.Inventory(client);
}