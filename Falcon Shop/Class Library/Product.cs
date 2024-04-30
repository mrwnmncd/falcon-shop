/**
    GUI:            Shop Products 
    UI DESIGNER:    Sean David Vallespin

    GRAPHICAL USER INTERFACE (GUI) DESIGN
    Form Name:      Products
    View For:       Customer
*/


namespace FalconShop.ClassLibrary;

public class Product
{
    // do not include in the GUI
    public String Id { get; set; } = "";  
    /* GUI CONTROL:         Label */
    public String Name { get; set; } = ""; 
    /* GUI CONTROL:         Label */
    public String Description { get; set; } = ""; 

    /* GUI CONTROL:         Label */
    public Double Price { get; set; } 

    public Dictionary<String, dynamic>? Specifications { get; set; } = new Dictionary<String, dynamic>() {
        { "Size", "" },
        { "Color", "" },
        { "Type", "" },
        { "Variants", new String[] {} }
    };

    /* GUI CONTROL:         Label */
    public String? Type { get; set; }
}