using System.Text.Json;

namespace FalconShop;

public class User {
    public String Id { get; set; } // Textbox, Label
    public String Type { get; set; } = ""; // Dropdown 
    public String Forename { get; set; } = ""; // Textbox, Label
    public String? MiddleName { get; set; } = null; // Textbox, Label
    public String Surname { get; set; } = ""; // Textbox, Label
    public String FullName { // Label
        get { return Forename + " " + Surname; }
    }
}