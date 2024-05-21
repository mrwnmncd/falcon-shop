using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.GUI {
    public partial class StudentHome : Form {
        private readonly Client _client;

        public StudentHome(Client client) {
            _client = client;
            InitializeComponent();
        }

        private void RenderShopUI() {
            _client.UI.ShopItems.Show();
            this.Hide();
        }

        private void RenderCheckoutUI() {
            _client.UI.Checkout.Show();
            this.Hide();
        }

        private void RenderOrdersUI() {
            _client.UI.Checkout.Show();
            this.Hide();
        }

        private void LoadComponents() {
            if (_client.User.IsLoggedIn) {
                Label_Email.Text = _client.User.Account?.Email;
                Label_FullName.Text = _client.User.Account?.FullName;
                Label_GreetUser.Text = $"Hello, {_client.User.Account?.Forename}!";
                Label_UserID.Text = $"@{_client.User.Account?.Username} ({_client.User.Account?.Id})";
            }
            else {
                _client.UI.Login.Show();
                /*
                 * 1. SHOW ERROR
                 * 2. SHOW REGISTER
                 */
            }
        }

        private void LogoutUser() {
            _client.User.Logout();
            this.Hide();
            _client.UI.Login.Show();
        }
    }
}

namespace App.GUI {
    partial class StudentHome {
        private void EventTrigger_Shown(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: SHOWN");
        }

        private void EventTrigger_Load(object sender, EventArgs e) {
            Console.WriteLine("PROGRAM [GUI] STUDENT HOME UI");
            Console.WriteLine("    " + $"EVENT: LOAD");
            LoadComponents();
        }

        private void EventTrigger_FormClosing(object sender, FormClosingEventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLOSING");
        }

        private void EventTrigger_FormClosed(object sender, FormClosedEventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLOSED");
        }

        private void Button_Shop_Click(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLICKED SHOP");
            RenderShopUI();
        }

        private void Button_Checkout_Click(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLICKED CHECKOUT");
            RenderCheckoutUI();
        }

        private void Button_Orders_Click(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLICKED ORDERS");
            RenderOrdersUI();
        }
        
        private void Label_Log_Out_Click(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLICKED LOG OUT");
            LogoutUser();
        }
    }
}