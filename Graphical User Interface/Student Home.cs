using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.GUI
{
    public partial class StudentHome : Form
    {
        private readonly Client _client;
        public StudentHome(Client client)
        {
            _client = client;
            InitializeComponent();
        }

        private void RenderShopUI(object sender, EventArgs e)
        {
            Console.WriteLine("PROGRAM [GUI] RENDERED STUDENT HOME UI");
            _client.UI.Products.Show();
        }
        
        private void RenderCheckoutUI(object sender, EventArgs e)
        {
            Console.WriteLine("PROGRAM [GUI] RENDERED STUDENT HOME UI");
            _client.UI.Checkout.Show();
        }
        
          
        private void RenderOrdersUI(object sender, EventArgs e)
        {
            Console.WriteLine("PROGRAM [GUI] RENDERED STUDENT HOME UI");
            _client.UI.Checkout.Show();
        }
    }
}
