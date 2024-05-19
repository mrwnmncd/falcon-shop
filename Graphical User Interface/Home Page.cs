using App.Models;

namespace App.GUI {
    public partial class Home : Form
    {
        private readonly Client _client;
        public Home(Client client)
        {
            _client = client;
            InitializeComponent();
        }

        /*
         * Home_Load
         */

        private void Trigger_Shown(object sender, EventArgs e)
        {

            Console.WriteLine("PROGRAM [GUI] RENDERED HOME UI");


            label_FirstName.Text = _client.User.Account?.Forename + "!";
            label_FullName.Text = _client.User.Account?.FullName;
            label_Username.Text = _client.User.Account?.Username;
            label_Email.Text = _client.User.Account?.Email;
        }

        private void button_Products_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"PROGRAM [GUI] RENDER PRODUCTS UI");
            _client.UI.Products.Show();
        }

        private void button_Cart_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"PROGRAM [GUI] RENDER CART UI");
            _client.UI.Cart.Show();
        }

        private void button_Checkout_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"PROGRAM [GUI] RENDER CHECKOUT UI");
            _client.UI.Checkout.Show();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("    " + $"GUI: CLOSE HOME");
            // this.Hide();
            // e.Cancel = true;
            Application.Exit();
            // TODO: Fix this
        }

        /*
         * button_Products_Click
         * button_Cart_Click
         * button_Checkout_Click
         */

    }
}