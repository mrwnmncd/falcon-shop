namespace App.GUI
{
    public partial class SignUp : Form
    {
        public SignUp(Client client)
        {
            InitializeComponent();
        }
        
        private void Trigger_Shown(object sender, EventArgs e)
        {
            Console.WriteLine("PROGRAM [GUI] RENDERED SIGN UP UI");
        }
    }
}