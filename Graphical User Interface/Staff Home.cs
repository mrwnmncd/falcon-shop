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
    public partial class StaffHome : Form {
        private readonly Client _client;

        public StaffHome(Client client) {
            _client = client;
            InitializeComponent();
        }

        private void RenderOrdersUI() {
            // _client.UI.Orders.Show();

            /* TODO: create orders UI */
        }

        private void RenderInventoryUI() {
            // _client.UI.Inventory.Show();

            /* TODO: create inventory UI */
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
    partial class StaffHome {
        private void EventTrigger_Shown(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: SHOWN");
        }

        private void EevntTrigger_Load(object sender, EventArgs e) {
            Console.WriteLine("PROGRAM [GUI] STUDENT HOME UI");
            Console.WriteLine("    " + $"EVENT: LOAD");
            LoadComponents();
        }

        private void EventTrigger_FormClosing(object sender, FormClosingEventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLOSING");
        }

        private void EventTrigger_FormClosed(object sender, FormClosedEventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLOSED");
            _client.Exit();
        }

        private void Button_Orders_Click(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLICKED ORDERS");
            RenderOrdersUI();
        }

        private void Button_Inventory_Click(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLICKED INVENTORY");
            RenderInventoryUI();
        }
        
        private void Label_Log_Out_Click(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLICKED LOG OUT");
            LogoutUser();
        }
    }
}