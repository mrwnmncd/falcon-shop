using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using App.Models;

namespace App.GUI {
    public partial class Products : Form {
        private readonly Client _client;

        public Products(Client client) {
            _client = client;
            InitializeComponent();
        }

        private void Trigger_Shown(object sender, EventArgs e) {
            Console.WriteLine("PROGRAM [GUI] RENDERED PRODUCT UI");
        }

        private void Closing(object sender, FormClosingEventArgs e) {
            Console.WriteLine("    " + $"GUI: CLOSE PRODUCTS");
            this.Hide();
            e.Cancel = true;
        }

        
    }
}