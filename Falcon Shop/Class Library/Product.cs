namespace FalconShop;

public class Product
{
    public String Id { get; set; } = ""; // Textbox, Label (hidden)
    public String Name { get; set; } = ""; // Textbox, Label
    public String Description { get; set; } = ""; // Textarea, Label

    public Double Price { get; set; } // Textbox, Label

    public Dictionary<String, dynamic>? Specifications { get; set; } = new Dictionary<String, dynamic>() {
        { "Size", "" },
        { "Color", "" },
        { "Type", "" },
        { "Variants", new String[] {"coral design", "rugged"} }

    };

    public String? Type { get; set; }
}