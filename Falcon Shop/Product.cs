namespace FalconShop;

public class Product
{
    public String Id { get; set; } = "";
    public String Name { get; set; } = "";
    public String Description { get; set; } = "";

    public Double Price { get; set; }

    public Dictionary<String, dynamic>? Specifications { get; set; } = new Dictionary<String, dynamic>() {
        { "Size", "" },
        { "Color", "" },
        { "Type", "" },
        { "Variants", new String[] {} }

    };

    public String? Type { get; set; }
}