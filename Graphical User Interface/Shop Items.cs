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
        private string itemSelection = default;

        public Products(Client client) {
            _client = client;
            InitializeComponent();
        }

        private void Trigger_Shown(object sender, EventArgs e) {
            Console.WriteLine("PROGRAM [GUI] RENDERED PRODUCT UI");
            ComboBox_SelectProduct.SelectedIndex = 0;
        }

        private void Closing(object sender, FormClosingEventArgs e) {
            Console.WriteLine("    " + $"GUI: CLOSE PRODUCTS");
            this.Hide();
            e.Cancel = true;
        }

        private void AddToCart(object sender, EventArgs e) {
            Console.WriteLine("PROGRAM [EVENT] ADD TO CART");
            Button_LogIn.Enabled = false;
            string productSelection = ListBox_SelectVariant.Text;
            string quantityInput = TextBox_Quantity.Text;

            int quantity = int.Parse(quantityInput);

            Console.WriteLine("    " + $"{itemSelection} {productSelection} x{quantity}");
            _client.User.Cart!.AddItem(new InventoryItem() { Id = itemSelection }, quantity);
            Label_ProgramMessage.Text = "Added to Cart!";
            Task.Delay(1000).Wait();
            Label_ProgramMessage.Text = "";
            Button_LogIn.Enabled = true;
        }

        private void ListBox_Select_Variant_SelectedIndexChanged(object sender, EventArgs e) {
            string productSelection = ListBox_SelectVariant.Text;

            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Products));
            switch (ListBox_SelectVariant.Text) {
                case "Male Polo - Extra Small":
                case "Male Polo - Small":
                case "Male Polo - Medium":
                case "Male Polo - Large":
                case "Male Polo - Extra Large":
                case "Male Polo - Double Extra Large":
                    PictureBox_Product.BackgroundImage = (Image)resources.GetObject("POLO");
                    break;
                case "Female Blouse - Extra Small":
                case "Female Blouse - Small":
                case "Female Blouse - Medium":
                case "Female Blouse - Large":
                case "Female Blouse - Extra Large":
                case "Female Blouse - Double Extra Large":
                    PictureBox_Product.BackgroundImage = (Image)resources.GetObject("BLOUSE");
                    break;
                case "Male Slacks - Extra Small":
                case "Male Slacks - Small":
                case "Male Slacks - Medium":
                case "Male Slacks - Large":
                case "Male Slacks - Extra Large":
                case "Male Slacks - Double Extra Large":
                    PictureBox_Product.BackgroundImage = (Image)resources.GetObject("PANTS");
                    break;
                case "Female Skirt - Small":
                case "Female Skirt - Medium":
                case "Female Skirt - Large":
                case "Female Skirt - Extra Large":
                case "Female Skirt - Double Extra Large":
                    PictureBox_Product.BackgroundImage = (Image)resources.GetObject("SKIRT");
                    break;
                case "Unisex PE Shirt - Extra Small":
                case "Unisex PE Shirt - Small":
                case "Unisex PE Shirt - Medium":
                case "Unisex PE Shirt - Large":
                case "Unisex PE Shirt - Extra Large":
                case "Unisex PE Shirt - Double Extra Large":
                    PictureBox_Product.BackgroundImage = (Image)resources.GetObject("PE UNIFORM");
                    break;
                case "Unisex Jogging Pants - Extra Small":
                case "Unisex Jogging Pants - Small":
                case "Unisex Jogging Pants - Medium":
                case "Unisex Jogging Pants - Large":
                case "Unisex Jogging Pants - Extra Large":
                case "Unisex Jogging Pants - Double Extra Large":
                    PictureBox_Product.BackgroundImage = (Image)resources.GetObject("PE PANTS");
                    break;
                case "Unisex NSTP Shirt - Extra Small":
                case "Unisex NSTP Shirt - Small":
                case "Unisex NSTP Shirt - Medium":
                case "Unisex NSTP Shirt - Large":
                case "Unisex NSTP Shirt - Extra Large":
                case "Unisex NSTP Shirt - Double Extra Large":
                    PictureBox_Product.BackgroundImage = (Image)resources.GetObject("NSTP SHIRT");
                    break;
                case "Lanyard - College of Architecture":
                case "Lanyard - College of Business Administration":
                case "Lanyard - College of Engineering":
                case "Lanyard - College of Law":
                case "Lanyard - College of Education and Liberal Arts":
                case "Lanyard - College of Nursing":
                case "Lanyard - College of Pharmacy":
                case "Lanyard - College of Science":
                case "Lanyard - Graduate School":
                case "Lanyard - St. Vincent School of Theology":
                case "Lanyard - Basic Education Department":
                    PictureBox_Product.BackgroundImage = (Image)resources.GetObject("LANYARD");
                    break;
                default:
                    PictureBox_Product.BackgroundImage = (Image)resources.GetObject("POLO");
                    break;
            }

            itemSelection = productSelection switch {
                "Male Polo - Extra Small" => "UNIFORM-001", "Male Polo - Small" => "UNIFORM-002",
                "Male Polo - Medium" => "UNIFORM-003", "Male Polo - Large" => "UNIFORM-004",
                "Male Polo - Extra Large" => "UNIFORM-005", "Male Polo - Double Extra Large" => "UNIFORM-006",
                "Female Blouse - Extra Small" => "UNIFORM-011", "Female Blouse - Small" => "UNIFORM-012",
                "Female Blouse - Medium" => "UNIFORM-013", "Female Blouse - Large" => "UNIFORM-014",
                "Female Blouse - Extra Large" => "UNIFORM-015", "Female Blouse - Double Extra Large" => "UNIFORM-016",
                "Male Slacks - Extra Small" => "UNIFORM-021", "Male Slacks - Small" => "UNIFORM-022",
                "Male Slacks - Medium" => "UNIFORM-023", "Male Slacks - Large" => "UNIFORM-024",
                "Male Slacks - Extra Large" => "UNIFORM-025", "Male Slacks - Double Extra Large" => "UNIFORM-026",
                "Female Skirt - Extra Small" => "UNIFORM-031", "Female Skirt - Small" => "UNIFORM-032",
                "Female Skirt - Medium" => "UNIFORM-033", "Female Skirt - Large" => "UNIFORM-034",
                "Female Skirt - Extra Large" => "UNIFORM-035", "Female Skirt - Double Extra Large" => "UNIFORM-036",
                "Unisex PE Shirt - Extra Small" => "UNIFORM-041", "Unisex PE Shirt - Small" => "UNIFORM-042",
                "Unisex PE Shirt - Medium" => "UNIFORM-043", "Unisex PE Shirt - Large" => "UNIFORM-044",
                "Unisex PE Shirt - Extra Large" => "UNIFORM-045", "Unisex PE Shirt - Double Extra Large" => "UNIFORM-046",
                "Unisex Jogging Pants - Extra Small" => "UNIFORM-051", "Unisex Jogging Pants - Small" => "UNIFORM-052",
                "Unisex Jogging Pants - Medium" => "UNIFORM-053", "Unisex Jogging Pants - Large" => "UNIFORM-054",
                "Unisex Jogging Pants - Extra Large" => "UNIFORM-054",
                "Unisex Jogging Pants - Double Extra Large" => "UNIFORM-055", "Unisex NSTP Shirt - Extra Small" => "UNIFORM-061",
                "Unisex NSTP Shirt - Small" => "UNIFORM-062", "Unisex NSTP Shirt - Medium" => "UNIFORM-063",
                "Unisex NSTP Shirt - Large" => "UNIFORM-064", "Unisex NSTP Shirt - Extra Large" => "UNIFORM-065",
                "Unisex NSTP Shirt - Double Extra Large" => "UNIFORM-066",
                "Lanyard - College of Architecture" => "ACCESSORIES-011",
                "Lanyard - College of Business Administration" => "ACCESSORIES-010",
                "Lanyard - College of Engineering" => "ACCESSORIES-009", "Lanyard - College of Law" => "ACCESSORIES-008",
                "Lanyard - College of Education and Liberal Arts" => "ACCESSORIES-002",
                "Lanyard - College of Nursing" => "ACCESSORIES-003", "Lanyard - College of Pharmacy" => "ACCESSORIES-004",
                "Lanyard - College of Science" => "ACCESSORIES-001", "Lanyard - Graduate School" => "ACCESSORIES-005",
                "Lanyard - St. Vincent School of Theology" => "ACCESSORIES-006",
                "Lanyard - Basic Education Department" => "ACCESSORIES-007",
            };

            Console.WriteLine(_client.Store.FindProductById(productSelection)?.Price.ToString());

            Label_Price.Text = _client.Store.FindProductById(productSelection)?.Price.ToString() ?? "0.00";
        }

        private void ComboBox_Select_Product_SelectedIndexChanged(object sender, EventArgs e) {
            ListBox_SelectVariant.Items.Clear();
            switch (ComboBox_SelectProduct.Text) {
                case "UNIFORM":
                    ListBox_SelectVariant.Items.Add("Male Polo - Extra Small");
                    ListBox_SelectVariant.Items.Add("Male Polo - Small");
                    ListBox_SelectVariant.Items.Add("Male Polo - Medium");
                    ListBox_SelectVariant.Items.Add("Male Polo - Large");
                    ListBox_SelectVariant.Items.Add("Male Polo - Extra Large");
                    ListBox_SelectVariant.Items.Add("Male Polo - Double Extra Large");
                    ListBox_SelectVariant.Items.Add("Female Blouse - Extra Small");
                    ListBox_SelectVariant.Items.Add("Female Blouse - Small");
                    ListBox_SelectVariant.Items.Add("Female Blouse - Medium");
                    ListBox_SelectVariant.Items.Add("Female Blouse - Large");
                    ListBox_SelectVariant.Items.Add("Female Blouse - Extra Large");
                    ListBox_SelectVariant.Items.Add("Female Blouse - Double Extra Large");
                    ListBox_SelectVariant.Items.Add("Male Slacks - Extra Small");
                    ListBox_SelectVariant.Items.Add("Male Slacks - Small");
                    ListBox_SelectVariant.Items.Add("Male Slacks - Medium");
                    ListBox_SelectVariant.Items.Add("Male Slacks - Large");
                    ListBox_SelectVariant.Items.Add("Male Slacks - Extra Large");
                    ListBox_SelectVariant.Items.Add("Male Slacks - Double Extra Large");
                    ListBox_SelectVariant.Items.Add("Female Skirt - Extra Small");
                    ListBox_SelectVariant.Items.Add("Female Skirt - Small");
                    ListBox_SelectVariant.Items.Add("Female Skirt - Medium");
                    ListBox_SelectVariant.Items.Add("Female Skirt - Large");
                    ListBox_SelectVariant.Items.Add("Female Skirt - Extra Large");
                    ListBox_SelectVariant.Items.Add("Female Skirt - Double Extra Large");
                    break;
                case "PE":
                    ListBox_SelectVariant.Items.Add("Unisex PE Shirt - Extra Small");
                    ListBox_SelectVariant.Items.Add("Unisex PE Shirt - Small");
                    ListBox_SelectVariant.Items.Add("Unisex PE Shirt - Medium");
                    ListBox_SelectVariant.Items.Add("Unisex PE Shirt - Large");
                    ListBox_SelectVariant.Items.Add("Unisex PE Shirt - Extra Large");
                    ListBox_SelectVariant.Items.Add("Unisex PE Shirt - Double Extra Large");
                    ListBox_SelectVariant.Items.Add("Unisex Jogging Pants - Extra Small");
                    ListBox_SelectVariant.Items.Add("Unisex Jogging Pants - Small");
                    ListBox_SelectVariant.Items.Add("Unisex Jogging Pants - Medium");
                    ListBox_SelectVariant.Items.Add("Unisex Jogging Pants - Large");
                    ListBox_SelectVariant.Items.Add("Unisex Jogging Pants - Extra Large");
                    ListBox_SelectVariant.Items.Add("Unisex Jogging Pants - Double Extra Large");
                    break;
                case "NSTP":
                    ListBox_SelectVariant.Items.Add("Unisex NSTP Shirt - Extra Small");
                    ListBox_SelectVariant.Items.Add("Unisex NSTP Shirt - Small");
                    ListBox_SelectVariant.Items.Add("Unisex NSTP Shirt - Medium");
                    ListBox_SelectVariant.Items.Add("Unisex NSTP Shirt - Large");
                    ListBox_SelectVariant.Items.Add("Unisex NSTP Shirt - Extra Large");
                    ListBox_SelectVariant.Items.Add("Unisex NSTP Shirt - Double Extra Large");
                    break;
                case "LANYARD":
                    ListBox_SelectVariant.Items.Add("Lanyard - College of Architecture");
                    ListBox_SelectVariant.Items.Add("Lanyard - College of Business Administration");
                    ListBox_SelectVariant.Items.Add("Lanyard - College of Engineering");
                    ListBox_SelectVariant.Items.Add("Lanyard - College of Law");
                    ListBox_SelectVariant.Items.Add("Lanyard - College of Education and Liberal Arts");
                    ListBox_SelectVariant.Items.Add("Lanyard - College of Nursing");
                    ListBox_SelectVariant.Items.Add("Lanyard - College of Pharmacy");
                    ListBox_SelectVariant.Items.Add("Lanyard - College of Science");
                    ListBox_SelectVariant.Items.Add("Lanyard - Graduate School");
                    ListBox_SelectVariant.Items.Add("Lanyard - St. Vincent School of Theology");
                    ListBox_SelectVariant.Items.Add("Lanyard - Basic Education Department");
                    break;
                default:
                    ListBox_SelectVariant.Items.AddRange(new object[] {
                        "Male Polo - Extra Small", "Male Polo - Small", "Male Polo - Medium", "Male Polo - Large",
                        "Male Polo - Extra Large", "Male Polo - Double Extra Large", "Female Blouse - Extra Small",
                        "Female Blouse - Small", "Female Blouse - Medium", "Female Blouse - Large", "Female Blouse - Extra Large",
                        "Female Blouse - Double Extra Large", "Male Slacks - Extra Small", "Male Slacks - Small",
                        "Male Slacks - Medium", "Male Slacks - Large", "Male Slacks - Extra Large",
                        "Male Slacks - Double Extra Large", "Female Skirt - Extra Small", "Female Skirt - Small",
                        "Female Skirt - Medium", "Female Skirt - Large", "Female Skirt - Extra Large",
                        "Female Skirt - Double Extra Large", "Unisex PE Shirt - Extra Small", "Unisex PE Shirt - Small",
                        "Unisex PE Shirt - Medium", "Unisex PE Shirt - Large", "Unisex PE Shirt - Extra Large",
                        "Unisex PE Shirt - Double Extra Large", "Unisex Jogging Pants - Extra Small",
                        "Unisex Jogging Pants - Small", "Unisex Jogging Pants - Medium", "Unisex Jogging Pants - Large",
                        "Unisex Jogging Pants - Extra Large", "Unisex Jogging Pants - Double Extra Large",
                        "Unisex NSTP Shirt - Extra Small", "Unisex NSTP Shirt - Small", "Unisex NSTP Shirt - Medium",
                        "Unisex NSTP Shirt - Large", "Unisex NSTP Shirt - Extra Large", "Unisex NSTP Shirt - Double Extra Large",
                        "College of Architecture", "College of Business Administration", "College of Engineering",
                        "College of Law", "College of Education and Liberal Arts", "College of Nursing", "College of Pharmacy",
                        "College of Science", "Graduate School", "St. Vincent School of Theology", "Basic Education Department"
                    });
                    break;
            }
        }
    }
}