using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.GUI {
    public partial class Splash : Form {
        private readonly Client _client;

        public Splash(Client client) {
            _client = client;
            InitializeComponent();
        }

        private void LoadComponents() {
            Task.Delay(2000).Wait();

            this.Hide();

            if (_client.User.IsLoggedIn) {
                _client.UI.StudentHome.Show();
            }
            else {
                _client.UI.Login.Show();
                /*
                 * 1. SHOW ERROR
                 * 2. SHOW REGISTER
                 */
            }
        }
    }
}


namespace App.GUI {
    partial class Splash {
        
        private void EventTrigger_Load(object sender, EventArgs e) {
            Console.WriteLine("PROGRAM [GUI] SPLASH UI");
            Console.WriteLine("    " + $"EVENT: LOAD");
        }
        private void EventTrigger_Shown(object sender, EventArgs e) {
            Console.WriteLine("    " + $"EVENT: SHOWN");
            LoadComponents();
        }
        
        private void EventTrigger_FormClosing(object sender, FormClosingEventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLOSING");
        }
        
        private void EventTrigger_FormClosed(object sender, FormClosedEventArgs e) {
            Console.WriteLine("    " + $"EVENT: CLOSED");
        }
    }
}