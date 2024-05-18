using System.Windows.Forms;
using App.GUI;

namespace App.Testing;

public abstract class SimulationUtilities {
    private static readonly string Prefix = "    [SIMULATION UTILITY]    ";

    public static void Login(Client client) {
        Console.WriteLine("SIMULATOR: UTILITIES");
        Console.WriteLine(Prefix + "GUI: LOGIN");
        client.User.Login("mrwnmncd", "200416");
    }
}