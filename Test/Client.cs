using System.Windows.Forms;
using App.GUI;
using App.Models;

namespace App.Testing;

public abstract class SimulationUtilities {
    private static readonly string Prefix = "    [SIMULATION UTILITY]    ";

    public static void Login(Client client) {
        Console.WriteLine("SIMULATOR: UTILITIES");
        Console.WriteLine(Prefix + "GUI: LOGIN");
        client.User.Login("mrwnmncd", "200416");
    }

    public static void AddToCart(Client client) {
        Console.WriteLine(Prefix + "CLIENT: ADD TO CART");
        client.User.Cart?.AddItem(new Product() {Id = "UNIFORM-001"}, 1);
        client.User.Cart?.AddItem(new Product() {Id = "UNIFORM-003"}, 1);
    }
}