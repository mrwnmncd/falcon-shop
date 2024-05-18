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

        public Products(Client client) {
            _client = client;
            InitializeComponent();
        }

        private void Trigger_Shown(object sender, EventArgs e) {
            Console.WriteLine("PROGRAM [GUI] RENDERED LOGIN UI");
        }

        private void Closing(object sender, FormClosingEventArgs e) {
            Console.WriteLine("    " + $"GUI: CLOSE PRODUCTS");
            this.Hide();
            e.Cancel = true;
        }

        private void AddToCart(object sender, EventArgs e) {
            Console.WriteLine("PROGRAM [EVENT] ADD TO CART");
        }

        private void AddToCart_UpperUnif(object sender, EventArgs e) {
            string size = ComboBox_UPPER_UNIF_SIZE.Text;
            int quantity = int.Parse(ComboBox_UPPER_UNIF_QUANTITY.Text);
            string gender = ComboBox_UPPER_UNIF_GENDER.Text;

            string productId = default;

            if (gender == "Male") {
                productId = size switch {
                    "XS" => "UNIFORM-001",
                    "S" => "UNIFORM-002",
                    "M" => "UNIFORM-003",
                    "L" => "UNIFORM-004",
                    "XL" => "UNIFORM-005",
                    _ => throw new ArgumentOutOfRangeException()
                };
            }
            else if (gender == "Female") {
                productId = size switch {
                    "XS" => "UNIFORM-011",
                    "S" => "UNIFORM-012",
                    "M" => "UNIFORM-013",
                    "L" => "UNIFORM-014",
                    "XL" => "UNIFORM-015",
                    _ => throw new ArgumentOutOfRangeException()
                };
            }

            Product product = new() { Id = productId };

            _client.User.Cart?.AddProduct(product, quantity);
        }

        private void AddToCart_LowerUnif(object sender, EventArgs e) {
            string size = ComboBox_LOWER_UNIF_SIZE.Text;
            int quantity = int.Parse(ComboBox_LOWER_UNIF_QUANTITY.Text);
            string gender = ComboBox_UPPER_UNIF_GENDER.Text;

            string productId = default;

            if (gender == "Male") {
                productId = size switch {
                    "XS" => "UNIFORM-006",
                    "S" => "UNIFORM-007",
                    "M" => "UNIFORM-008",
                    "L" => "UNIFORM-009",
                    "XL" => "UNIFORM-010",
                    _ => throw new ArgumentOutOfRangeException()
                };
            }
            else if (gender == "Female") {
                productId = size switch {
                    "XS" => "UNIFORM-021",
                    "S" => "UNIFORM-022",
                    "M" => "UNIFORM-023",
                    "L" => "UNIFORM-024",
                    "XL" => "UNIFORM-025",
                    _ => throw new ArgumentOutOfRangeException()
                };
            }

            Product product = new() { Id = productId };
            _client.User.Cart?.AddProduct(product, quantity);
        }

        private void AddToCart_UpperPE(object sender, EventArgs e) {
            string size = ComboBox_UPPER_PE_SIZE.Text;
            int quantity = int.Parse(ComboBox_UPPER_PE_QUANTITY.Text);
            string gender = ComboBox_UPPER_PE_GENDER.Text;

            string productId = default;

            productId = size switch {
                "XS" => "UNIFORM-026",
                "S" => "UNIFORM-027",
                "M" => "UNIFORM-028",
                "L" => "UNIFORM-029",
                "XL" => "UNIFORM-030",
                _ => throw new ArgumentOutOfRangeException()
            };

            Product product = new() { Id = productId };

            _client.User.Cart?.AddProduct(product, quantity);
        }

        private void AddToCart_LowerPE(object sender, EventArgs e) {
            string size = ComboBox_LOWER_PE_SIZE.Text;
            int quantity = int.Parse(ComboBox_LOWER_PE_QUANTITY.Text);
            string gender = ComboBox_UPPER_PE_GENDER.Text;

            string productId = default;

            if (gender == "Male") {
                productId = size switch {
                    "XS" => "UNIFORM-006",
                    "S" => "UNIFORM-007",
                    "M" => "UNIFORM-008",
                    "L" => "UNIFORM-009",
                    "XL" => "UNIFORM-010",
                    _ => throw new ArgumentOutOfRangeException()
                };
            }
            else if (gender == "Female") {
                productId = size switch {
                    "XS" => "UNIFORM-021",
                    "S" => "UNIFORM-022",
                    "M" => "UNIFORM-023",
                    "L" => "UNIFORM-024",
                    "XL" => "UNIFORM-025",
                    _ => throw new ArgumentOutOfRangeException()
                };
            }

            Product product = new() { Id = productId };
            _client.User.Cart?.AddProduct(product, quantity);
        }
    }
}