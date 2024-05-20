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
    public partial class Receipt : Form {
        private readonly Client _client;

        public Receipt(Client client) {
            _client = client;
            InitializeComponent();
        }

        private void TriggerOnRender(object sender, EventArgs e) {
            Console.WriteLine("PROGRAM [GUI] RENDERED RECEIPT UI");
            dynamic transaction = _client.Store.RecordTransaction(_client.User.Cart!);
            Label_ReferenceNumber.Text = transaction ?? "ERROR";
        }

        private void LogOut(object sender, EventArgs e) {
            Console.WriteLine("PROGRAM [CLIENT] LOGOUT");
            _client.UI.Home.Hide();
            this.Hide();
            _client.User.Account = null;
            _client.User.Cart = null;
            _client.UI.Login.Show();
        }
    }
}