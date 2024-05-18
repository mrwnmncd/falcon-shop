/*
    GUI:            User Signup, User Login
    UI DESIGNER:    JM Palsis (Sign Up)
                    Mharwin Moncada (Login)

    GRAPHICAL USER INTERFACE (GUI) DESIGN
    Form Name:      Signup
    View For:       Customer

    GRAPHICAL USER INTERFACE (GUI) DESIGN
    Form Name:      Login
    View For:       Customer
*/

using System.Text.Json;

namespace App.Models;

public class User {
    public string Id { get; set; } 
    public string Type { get; init; } = "";
    public string Forename { get; set; } = ""; 
    public string? MiddleName { get; set; } = null;
    public string Surname { get; set; } = "";
    public string FullName => Forename + " " + MiddleName + " " + Surname;
}