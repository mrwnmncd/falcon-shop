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


namespace FalconShop.ClassLibrary;

public class Account : User {

    /* GUI CONTROL:         Textbox, Label */
    public String? Email { get; set; } = null;
    
    /* GUI CONTROL:         Textbox, Label */
    public String Username { get; set; } = "";

    /* GUI CONTROL:         Textbox, Label */
    // NOTE: password must be masked (**********)
    public String Password { get; set; } = "";

    /* GUI CONTROL:         Label */
    public String FullName {
        get { return Forename + " " + MiddleName + " " + Surname; }
    }

    private String[] AccountType = new[] { "Customer", "Student", "Staff", "Admin" };

    public Account(String UserType) {
        if (AccountType.Contains(UserType))
            Type = UserType;
        else throw new Exception("Invalid user type");
    }

    public static bool? Validate(Account account) {
        if (String.IsNullOrEmpty(account.Id)) return false;
        if (String.IsNullOrEmpty(account.Forename) || String.IsNullOrEmpty(account.Surname)) return false;
        if (String.IsNullOrEmpty(account.Type)) return false;
        if (String.IsNullOrEmpty(account.Username) || String.IsNullOrEmpty(account.Password)) return false;
        return true;
    }
}