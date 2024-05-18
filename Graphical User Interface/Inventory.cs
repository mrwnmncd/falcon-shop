namespace App.GUI
{
    public partial class Inventory : Form
    {
        public Inventory(Client client)
        {
            InitializeComponent();
        }
        
        private void Trigger_Shown(object sender, EventArgs e)
        {
            Console.WriteLine("PROGRAM [GUI] RENDERED INVENTORY UI");
        }
        private void Closing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("    " + $"GUI: CLOSE PRODUCTS");
            this.Hide();
            e.Cancel = true;
        }
    }
}