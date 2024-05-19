using System.Windows.Controls;
using App.Models;

namespace App.GUI {
    public partial class Cart : Form {
        private readonly Client _client;

        public Cart(Client client) {
            _client = client;
            InitializeComponent();
        }

        private void Trigger_Shown(object sender, EventArgs e) {
            Console.WriteLine("PROGRAM [GUI] RENDERED CART UI");
        }

        private void Closing(object sender, FormClosingEventArgs e) {
            Console.WriteLine("    " + $"GUI: CLOSE PRODUCTS");
            this.Hide();
            e.Cancel = true;
        }

        private void RenderCart() {
            Models.Cart? cart = _client.User.Cart;

            foreach (InventoryItem item in cart!.Items) {
                ListBoxItem product = new ListBoxItem();
                product.AddText(item.Product.Name);
                ListBox_Enumerate_Cart.Items.add(product);
            }
        }
    }
}