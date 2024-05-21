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
    public partial class Checkout : Form {
        private readonly Client _client;

        public Checkout(Client client) {
            _client = client;
            InitializeComponent();
        }

        private void ReturnHome() {
            this.Hide();
            _client.UI.StudentHome.Show();
        }

        private void LoadComponents() {
            foreach (var item in _client.User.Cart!.Items) {
                string particular = $"{item.Name}      x {item.Quantity}    @  {item.Price:C}";
                ListBox_Enumerate_CartItems.Items.Add($"{item.Name},    x {item.Quantity},    @  {item.Price:C}");
            }

            Label_Cart_Count.Text = $"{_client.User.Cart!.Items.Count}";
            Label_Subtotal.Text = $"PHP {_client.User.Cart!.TotalPrice():C}";
            Label_ProgramMessage.Text = "";
        }

        private void ClearCart() {
            _client.User.Cart!.Clear();
            ListBox_Enumerate_CartItems.Items.Clear();
        }

        private void ClearItem() {
            for (int i = 0; i < ListBox_Enumerate_CartItems.SelectedItems.Count; i++) {
                string name = ListBox_Enumerate_CartItems.Items[i].ToString().Split(',')[0];
                Console.WriteLine("        " + $"APPLICATION: voiding item {name}");
                Models.Product voidItem = _client.Store.FindProductByName(name)!;
                _client.User.Cart!.RemoveItem(voidItem);
                ListBox_Enumerate_CartItems.Items.Remove(ListBox_Enumerate_CartItems.SelectedItems[i]);
                i--;
            }

            Label_Cart_Count.Text = $"{_client.User.Cart!.Items.Count}";
        }

        private void ShowReceipt() {
            this.Hide();
            _client.UI.Receipt.Show();
        }
    }
}

namespace App.GUI {
    partial class Checkout {
        private void EventTrigger_Shown(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: SHOWN");
        }

        private void EventTrigger_Load(object sender, EventArgs e) {
            Console.WriteLine("PROGRAM [GUI] CHECK OUT UI");
            Console.WriteLine("    " + $"EVENT: LOAD");
            LoadComponents();
        }

        private void EventTrigger_FormClosing(object sender, FormClosingEventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLOSING");
            this.Hide();
            e.Cancel = true;
            ReturnHome();
        }

        private void EventTrigger_FormClosed(object sender, FormClosedEventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLOSED");
        }

        private void Button_ClearCart_Click(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLICKED ADD TO CART");
            ClearCart();
        }

        private void Button_ClearItem_Click(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLICKED CLEAR ITEMS");
            ClearItem();
        }

        private void Button_SubmitOrder_Click(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLICKED SUBMIT ORDER");
            ShowReceipt();
        }

        private void Button_Home_Click(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLICKED HOME");
            ReturnHome();
        }
    }
}