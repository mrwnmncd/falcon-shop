namespace FalconShop;

public class Account : User {

    public String? Email { get; set; } = null;

    public String Username { get; set; } = "";
    public String Password { get; set; } = "";

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