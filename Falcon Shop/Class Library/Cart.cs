namespace FalconShop;

public class Cart
{
    public Account Account { get; set; }
    public Product[] Items { get; set; } = new Product[] {};

    public Cart(Account account)
    {
        if (account == null) throw new ArgumentNullException(nameof(account));
        Account = account;
    }

    public void AddToCart(Product product)
    {
        if (product == null) throw new ArgumentNullException(nameof(product));
        Items = Items.Append(product).ToArray();
    }

    public void RemoveFromCart(Product product)
    {
        if (product == null) throw new ArgumentNullException(nameof(product));
        Items = Items.Where(p => p.Id != product.Id).ToArray();
    }

    public Double TotalPrice()
    {
        return Items.Sum(p => p.Price);
    }

}


public class CartItem : Product
{
    public Int32 Quantity { get; set; } = 1;

    public CartItem(Product product)
    {
        if (product == null) throw new ArgumentNullException(nameof(product));
        Id = product.Id;
        Name = product.Name;
        Description = product.Description;
        Price = product.Price;
        Specifications = product.Specifications;
        Type = product.Type;
    }
}