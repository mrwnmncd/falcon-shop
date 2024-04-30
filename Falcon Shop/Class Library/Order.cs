/**
    GUI:            Checkout
    UI DESIGNER:    Yssa Clarisse Pasia (Checkout)

    GRAPHICAL USER INTERFACE (GUI) DESIGN
    Form Name:      Checkout
    View For:       Customer
*/


namespace FalconShop.ClassLibrary;

public class ShopOrder {
    /* GUI CONTROL:         Textbox (disabled), Label */
    // auto-generated order number; use as tracking number

    public string Id { get; set; } = "";

    
    public Account Account { get; set; }

    public Cart Cart { get; set; }

    public ShopOrder(Account account, Cart cart)
    {
        if (account == null) throw new ArgumentNullException(nameof(account));
        if (cart == null) throw new ArgumentNullException(nameof(cart));
        Account = account;
        Cart = cart;
    }
}