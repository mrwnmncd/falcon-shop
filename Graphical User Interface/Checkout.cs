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

        private void Trigger_Shown(object sender, EventArgs e) {
            foreach (var item in _client.User.Cart!.Items) {
                string particular = $"{item.Name}      x {item.Quantity}    @  {item.Price:C}";
                ListBox_Enumerate_CartItems.Items.Add($"{item.Name},    x {item.Quantity},    @  {item.Price:C}");
            }

            Label_Cart_Count.Text = $"{_client.User.Cart!.Items.Count}";
            Label_Subtotal.Text = $"PHP {_client.User.Cart!.TotalPrice():C}";
            Label_ProgramMessage.Text = "";
        }

        private void Closing(object sender, FormClosingEventArgs e) {
            Console.WriteLine("    " + $"GUI: CLOSE PRODUCTS");
            this.Hide();
            e.Cancel = true;
        }

        private void Button_CancelOrder_Click(object sender, EventArgs e) {
            _client.User.Cart!.Clear();
            ListBox_Enumerate_CartItems.Items.Clear();
        }

        private void Button_ClearItems_Click(object sender, EventArgs e) {
            for (int i = 0; i < ListBox_Enumerate_CartItems.SelectedItems.Count; i++) {
                string name = ListBox_Enumerate_CartItems.Items[i].ToString().Split(',')[0];
                Console.WriteLine($"PROGRAM (CLIENT) CHECKOUT: void {name}");
                Models.Product voidItem = _client.Store.FindProductByName(name)!;
                _client.User.Cart!.RemoveItem(voidItem);
                ListBox_Enumerate_CartItems.Items.Remove(ListBox_Enumerate_CartItems.SelectedItems[i]);
                i--;
            }

            Label_Cart_Count.Text = $"{_client.User.Cart!.Items.Count}";
        }

        private void Button_SubmitOrder_Click(object sender, EventArgs e) {
            this.Hide();
            _client.UI.Receipt.Show();
        }
    }
}