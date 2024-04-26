using System.Text.Json;

namespace FalconShop;

public class Account
{
    public String Id { get; set; } = "";
    public String Type { get; set; } = "";
    public String Forename { get; set; } = "";
    public String Surname { get; set; } = "";
    public String? Program { get; set; } = null;
    public String? Sex { get; set; } = null;
    public String? Department { get; set; } = null;
    public String FullName { get { return Forename + " " + Surname; } }

    private String[] AccountType = new[] { "Student", "Staff", "Admin" };

    public Account(String id, String type, String forename, String surname)
    {
        if (String.IsNullOrEmpty(id)) throw new ArgumentNullException(nameof(id));
        if (String.IsNullOrEmpty(type)) throw new ArgumentNullException(nameof(type));
        if (String.IsNullOrEmpty(forename)) throw new ArgumentNullException(nameof(forename));
        if (String.IsNullOrEmpty(surname)) throw new ArgumentNullException(nameof(surname));

        if (id.Length != 9) throw new ArgumentException("Id must be 9 characters long", nameof(id));
        if (!AccountType.Contains(type)) throw new ArgumentException("Type must be Student, Staff or Admin", nameof(type));


        Id = id;
        Type = type;
        Forename = forename;
        Surname = surname;
    }


    public String ToJson()
    {
        return JsonSerializer.Serialize(
            new { Id, Type, Forename, Surname, FullName }
        );
    }


}
