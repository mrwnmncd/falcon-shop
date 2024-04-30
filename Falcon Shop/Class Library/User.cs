/**
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

namespace FalconShop.ClassLibrary;

public class User {
    /* GUI CONTROL:         Textbox, Label */
    public String Id { get; set; } 
    /* GUI CONTROL:         ComboBox [ "Customer", "Student", "Staff", "Admin" ], Label */
    public String Type { get; set; } = "";
    /* GUI CONTROL:         Textbox, Label */
    public String Forename { get; set; } = ""; 
    /* GUI CONTROL:         Textbox, Label */
    public String? MiddleName { get; set; } = null;
    /* GUI CONTROL:         Textbox, Label */
    public String Surname { get; set; } = "";
    /* GUI CONTROL:         Label */
    public String FullName {
        get { return Forename + " " + Surname; }
    }
}