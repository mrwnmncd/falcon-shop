namespace FalconShop;

public class ShopOrder {
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