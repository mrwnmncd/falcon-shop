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
            Console.WriteLine("PROGRAM [GUI] RENDERED PRODUCT UI");
        }

        private void Closing(object sender, FormClosingEventArgs e) {
            Console.WriteLine("    " + $"GUI: CLOSE PRODUCTS");
            this.Hide();
            e.Cancel = true;
        }

        private void AddToCart(object sender, EventArgs e) {
            Console.WriteLine("PROGRAM [EVENT] ADD TO CART");

            foreach (InventoryItem item in _client.User.Cart.Items) {
                Console.WriteLine($"    {item.Id} {item.Name} x{item.Quantity}");
            }
        }

        private void AddToCart_UpperUnif(object sender, EventArgs e) {
            string size = ComboBox_UPPER_UNIF_SIZE.Text;
            string inputQuantity = ComboBox_UPPER_UNIF_QUANTITY.Text;
            int quantity = int.Parse(inputQuantity);
            string gender = ComboBox_UPPER_UNIF_GENDER.Text;

            string productId = default;
            Product product = new();

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

            product.Id = productId;
            _client.User.Cart?.AddProduct(product, quantity);
        }

        private void AddToCart_LowerUnif(object sender, EventArgs e) {
            string size = ComboBox_LOWER_UNIF_SIZE.Text;
            string inputQuantity = ComboBox_LOWER_UNIF_QUANTITY.Text;
            int quantity = int.Parse(inputQuantity);
            string gender = ComboBox_LOWER_UNIF_GENDER.Text;

            string productId = default;
            Product product = new();

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

            product.Id = productId;
            _client.User.Cart?.AddProduct(product, quantity);
        }

        private void AddToCart_UpperPE(object sender, EventArgs e) {
            string size = ComboBox_UPPER_PE_SIZE.Text;
            string inputQuantity = ComboBox_UPPER_PE_QUANTITY.Text;
            int quantity = int.Parse(inputQuantity);
            string gender = ComboBox_UPPER_PE_GENDER.Text;

            string productId = default;
            Product product = new();

            productId = size switch {
                "XS" => "UNIFORM-026",
                "S" => "UNIFORM-027",
                "M" => "UNIFORM-028",
                "L" => "UNIFORM-029",
                "XL" => "UNIFORM-030",
                _ => throw new ArgumentOutOfRangeException()
            };

            product.Id = productId;
            _client.User.Cart?.AddProduct(product, quantity);
        }

        private void AddToCart_LowerPE(object sender, EventArgs e) {
            string size = ComboBox_LOWER_PE_SIZE.Text;
            string inputQuantity = ComboBox_LOWER_PE_QUANTITY.Text;
            int quantity = int.Parse(inputQuantity);
            string gender = ComboBox_LOWER_PE_GENDER.Text;

            string productId = default;
            Product product = new();

            productId = size switch {
                "XS" => "UNIFORM-031",
                "S" => "UNIFORM-032",
                "M" => "UNIFORM-033",
                "L" => "UNIFORM-034",
                "XL" => "UNIFORM-035",
                _ => throw new ArgumentOutOfRangeException()
            };

            product.Id = productId;
            _client.User.Cart?.AddProduct(product, quantity);
        }

        private void AddToCart_PESet(object sender, EventArgs e) {
            string size = ComboBox_SET_PE_SIZE.Text;
            string inputQuantity = ComboBox_SET_PE_QUANTITY.Text;
            int quantity = int.Parse(inputQuantity);
            string gender = ComboBox_SET_PE_GENDER.Text;

            string productId = default;
            Product product = new();

            productId = size switch {
                "XS" => "UNIFORM-026",
                "S" => "UNIFORM-027",
                "M" => "UNIFORM-028",
                "L" => "UNIFORM-029",
                "XL" => "UNIFORM-030",
                _ => throw new ArgumentOutOfRangeException()
            };

            product.Id = productId;
            _client.User.Cart?.AddProduct(product, quantity);

            productId = size switch {
                "XS" => "UNIFORM-031",
                "S" => "UNIFORM-032",
                "M" => "UNIFORM-033",
                "L" => "UNIFORM-034",
                "XL" => "UNIFORM-035",
                _ => throw new ArgumentOutOfRangeException()
            };

            product.Id = productId;
            _client.User.Cart?.AddProduct(product, quantity);
        }

        private void AddToCart_UnifSet(object sender, EventArgs e) {
            string size = ComboBox_SET_UNIF_SIZE.Text;
            string inputQuantity = ComboBox_SET_UNIF_QUANTITY.Text;
            int quantity = int.Parse(inputQuantity);
            string gender = ComboBox_SET_UNIF_GENDER.Text;

            string productId = default;
            Product product = new();

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

            product.Id = productId;
            _client.User.Cart?.AddProduct(product, quantity);

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

            product.Id = productId;
            _client.User.Cart?.AddProduct(product, quantity);
        }
        
        private void AddToCart_NSTP(object sender, EventArgs e) {
            string size = ComboBox_NSTP_SHIRT_SIZE.Text;
            string inputQuantity = ComboBox_NSTP_SHIRT_QUANTITY.Text;
            int quantity = int.Parse(inputQuantity);
            string gender = ComboBox_NSTP_SHIRT_GENDER.Text;

            string productId = default;
            Product product = new();

            productId = size switch {
                "XS" => "UNIFORM-036",
                "S" => "UNIFORM-037",
                "M" => "UNIFORM-038",
                "L" => "UNIFORM-039",
                "XL" => "UNIFORM-040",
                _ => throw new ArgumentOutOfRangeException()
            };

            product.Id = productId;
            _client.User.Cart?.AddProduct(product, quantity);
        }
    }
}