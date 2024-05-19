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
    public partial class Login : Form
    {
        private readonly Client _client;
        public Login(Client client)
        {
            _client = client;
            InitializeComponent();
        }
        
        private void Trigger_Shown(object sender, EventArgs e) {
            Console.WriteLine("APPLICATION [GUI] RENDERED LOGIN UI");

            if (_client.User.IsLoggedIn) {
                Console.WriteLine("    " + $"LOGIN: ALREADY LOGGED IN {_client.User.Account?.Username}");
                this.Hide();
                _client.UI.Home.Show();
            }
        }

        private void Button_Log_In_Click(object sender, EventArgs e) {
            string username = TextBox_Enter_UsernameID.Text;
            string password = TextBox_Enter_Password.Text;

            Console.WriteLine($"PROGRAM [EVENT] ATTEMPT LOGIN");
            Console.WriteLine("    " + $"LOGIN: TRYING {username}:{password}");

            bool login = _client.User.Login(username, password);
            if (login) {
                Console.WriteLine("    " + $"LOGIN: LOGGED IN {_client.User.Account?.Username}");
                this.Hide();
                _client.UI.Home.Show();
            }
            else Console.WriteLine("    " + $"LOGIN: FAILED {username}");
        }
        
        private void Label_Sign_Up_Click(object sender, EventArgs e) {
            Console.WriteLine($"APPLICATION [EVENT] REDIRECT SIGN UP");
            
            this.Hide();
            _client.UI.SignUp.Show();
        }
    }
}
