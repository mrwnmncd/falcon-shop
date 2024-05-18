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

        private void Trigger_Shown(object sender, EventArgs e) {
            Console.WriteLine("PROGRAM [GUI] RENDERED SPLASH UI");
            Task.Delay(2000).Wait();

            this.Hide();

            if (_client.User.IsLoggedIn) {
                _client.UI.Home.Show();
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