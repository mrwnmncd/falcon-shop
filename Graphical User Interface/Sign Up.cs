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
        
        private void InitiateSignUp() {

            string IdNumber = TextBox_ID_Number.Text;
            string Forename = TextBox_Enter_Given_Name.Text;
            string Surname = TextBox_Enter_Surname.Text;
            /* TODO: add username field */
            string Password = TextBox_Enter_Passphrase.Text;
            string ConfirmPassword = TextBox_Confirm_Passphrase.Text;
            string Email = TextBox_Enter_Email.Text;
            
            /* TODO: handle signup on client */
        }
        
        private void RedirectFormLogin() {
            this.Hide();
            _client.UI.Login.Show();
        }
    }
}

namespace App.GUI {
    partial class SignUp {
        private void EventTrigger_Shown(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: SHOWN");
        }

        private void EevntTrigger_Load(object sender, EventArgs e) {
            Console.WriteLine("PROGRAM [GUI] SIGN UP UI");
            Console.WriteLine("    " + $"EVENT: LOAD");
        }

        private void EventTrigger_FormClosing(object sender, FormClosingEventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLOSING");
        }

        private void EventTrigger_FormClosed(object sender, FormClosedEventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLOSED");
            _client.Exit();
        }
        
        private void Button_SignUp_Click(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLICKED SIGN UP");
            InitiateSignUp();
        }
        
        private void Label_Login_Click(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLICKED LOGIN");
            RedirectFormLogin();
        }
    }
}