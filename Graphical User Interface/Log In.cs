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
    public partial class Login : Form {
        private readonly Client _client;

        public Login(Client client) {
            _client = client;
            InitializeComponent();
        }

        private void CheckSession() {
            if (_client.User.IsLoggedIn) {
                Console.WriteLine("        " + $"APPLICATION: ALREADY LOGGED IN {_client.User.Account?.Username}");
                this.Hide();
                if (_client.User.Account?.Type == "Staff") /* TODO: define this in a constant or class */
                    _client.UI.StaffHome.Show();
                else _client.UI.StudentHome.Show();
            }
        }

        private void InitiateLogin() {
            string username = TextBox_Enter_UsernameID.Text;
            string password = TextBox_Enter_Password.Text;

            Console.WriteLine("        " + $"APPLICATION: LOGGING IN {username}:{password}");
            bool login = _client.User.Login(username, password);
            if (login) {
                Console.WriteLine("        " + $"APPLICATION: LOGGED IN {_client.User.Account?.Username}");
                this.Hide();
                if (_client.User.Account?.Type == "Staff") /* TODO: define this in a constant or class */
                    _client.UI.StaffHome.Show();
                else _client.UI.StudentHome.Show();
            }
            else Console.WriteLine("        " + $"APPLICATION: LOGIN FAILED ({username})");
        }

        private void RedirectFormSignUp() {
            this.Hide();
            _client.UI.SignUp.Show();
        }
    }
}

namespace App.GUI {
    partial class Login {
        private void EventTrigger_Shown(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: SHOWN");
        }

        private void EevntTrigger_Load(object sender, EventArgs e) {
            Console.WriteLine("PROGRAM [GUI] LOGIN UI");
            Console.WriteLine("    " + $"EVENT: LOAD");
        }

        private void EventTrigger_FormClosing(object sender, FormClosingEventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLOSING");
        }

        private void EventTrigger_FormClosed(object sender, FormClosedEventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLOSED"); 
            _client.Exit();
        }

        private void Button_Log_In_Click(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLICKED LOG IN");
            InitiateLogin();
        }

        private void Label_Sign_Up_Click(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLICKED SIGN UP");
            RedirectFormSignUp();
        }
    }
}