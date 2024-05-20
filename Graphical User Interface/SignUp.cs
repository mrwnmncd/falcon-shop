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
    public partial class SignUp : Form
    {
        private readonly Client _client;
        public SignUp(Client client)
        {
            _client = client;
            InitializeComponent();
        }
       
        private void Trigger_Shown(object sender, EventArgs e)
        {
            Console.WriteLine("PROGRAM [GUI] RENDERED SIGN UP UI");
        }
    }
}
