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
        
        private void ReturnHome() {
            this.Hide();
            _client.UI.StudentHome.Show();
        }


        private void LoadComponents() {
            dynamic transaction = _client.Store.RecordTransaction(_client.User.Cart!);
            Label_ReferenceNumber.Text = transaction ?? "ERROR";
        }

        private void LogOut(object sender, EventArgs e) {
            Console.WriteLine("PROGRAM [CLIENT] LOGOUT");
            this.Hide();
            _client.User.Logout();
            ReturnHome();
        }
    }
}

namespace App.GUI {
    partial class Receipt {
        private void EventTrigger_Shown(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: SHOWN");
        }

        private void EventTrigger_Load(object sender, EventArgs e) {
            Console.WriteLine("PROGRAM [GUI] RECEIPT UI");
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

        private void Button_Confirm_Click(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLICKED CONFIRM");
            ReturnHome();
        }
    }
}