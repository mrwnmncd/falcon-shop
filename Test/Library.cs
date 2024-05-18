using System;
using System.Collections.Generic;
using App.API;
using App.Models;

namespace App.Testing;

public abstract class Library {
    public static void APPLICATION() {
        Store store = new();
        {
            /*
             * TESTING LOGIN
             * 1. Access the Account
             * 2. Log in with valid credentials
             * 3. Log in with invalid credentials
             */

            Console.WriteLine("TEST: LOGIN");
            Account? account = new();

            { // LOG IN WITH INVALID CREDENTIALS
                account.Username = "mrwnmncd";
                account.Password = "admin";

                Console.WriteLine("    " + $"LOGIN: {account.Username}:{account.Password} (asserting false)");
                account = Account.Login(account.Username, account.Password);
                if (account == null) {
                    Console.WriteLine("    " + "    " + "Invalid credentials");
                    account = new Account();
                }
                else Console.WriteLine("    " + "    " + account.Id + " " + account.Username + " " + account.FullName);
            }
            { // LOG IN WITH VALID CREDENTIALS
                account.Username = "mrwnmncd";
                account.Password = "200416";

                Console.WriteLine("    " + $"LOGIN: {account.Username}:{account.Password} (asserting true)");
                account = Account.Login(account.Username, account.Password);
                if (account == null) {
                    Console.WriteLine("    " + "    " + "Invalid credentials");
                    account = new Account();
                }
                else Console.WriteLine("    " + "    " + account.Id + " " + account.Username + " " + account.FullName);
            }
        }


        {
            /*
             * TESTING REGISTER
             * 1. Define the Account Information
             * 2. Define the User Information
             * 3. Register the Account
             */
            Console.WriteLine("TEST: REGISTER");
            Dictionary<string, string> UserRyan = new() {
                { "Id", "202313499" },
                { "Type", "Student" },
                { "Forename", "Ryan Vincent" },
                { "MiddleName", "Caperal" },
                { "Surname", "Tolentino" }
            };

            Dictionary<string, string> AccountRyan = new() {
                { "Id", "202313499" },
                { "Username", "raiyant" },
                { "Password", "ryantolentino" },
                { "Email", "ryan.vincent.tolentino@adamson.edu.ph" }
            };

            Account account = new() {
                Id = AccountRyan["Id"],
                Username = AccountRyan["Username"],
                Password = AccountRyan["Password"],
                Email = AccountRyan["Email"],
                Type = UserRyan["Type"],
                Forename = UserRyan["Forename"],
                MiddleName = UserRyan["MiddleName"],
                Surname = UserRyan["Surname"]
            };

            dynamic register = account.Register();

            Console.WriteLine("    " + $"REGISTER: {account.Username}:{account.Password}");

            if (register is false) Console.WriteLine("    " + "    " + "Account already exists");
            else Console.WriteLine("    " + "    " + register);
        }

        { // TESTING CART
            /*
             * 1. Access the Account
             * 2. Access the Cart of the Account
             * 3. Add a Product to the Cart
             * 4. Remove a Product from the Cart
             * 5. Calculate the Total Price of the Cart
             */

            Console.WriteLine("TEST: CART");
            Account account = new() {
                Username = "mrwnmncd",
                Password = "200416"
            };
            Cart userCart = new Cart(account, store);

            {
                { // ADD PRODUCT TO STORE
                    Console.WriteLine("    " + "STORE: ADD PRODUCT TO STORE");
                    store.AddProduct(new InventoryItem() {
                        Id = "UNIFORM-001",
                        Name = "Polo",
                        Description = "Adamson University Polo Shirt for Men",
                        Price = 460,
                        Specifications = new() {
                            { "Size", "XS" },
                            { "Color", "White" },
                            { "Type", "Polo" },
                            { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
                        },
                        Quantity = 1000
                    });
                    Console.WriteLine("    " + "STORE: ADD PRODUCT TO STORE");
                    store.AddProduct(new InventoryItem() {
                        Id = "UNIFORM-002",
                        Name = "Polo",
                        Description = "Adamson University Polo Shirt for Men",
                        Price = 460,
                        Specifications = new() {
                            { "Size", "S" },
                            { "Color", "White" },
                            { "Type", "Polo" },
                            { "Variants", new[] { "XS", "S", "M", "L", "XL" } }
                        },
                        Quantity = 1000
                    });
                }

                {
                    // LOOKUP PRODUCT
                    Console.WriteLine("    " + "STORE: LOOKUP PRODUCT");
                    {
                        foreach (InventoryItem? item in store.Inventory) {
                            Console.WriteLine("    " + "    " + "LOOKUP STORE: " + item?.Id);
                            if (item?.Id == "UNIFORM-001") { }
                        }
                    }
                    // if (searchProduct != null) Console.WriteLine("    " + "    " + searchProduct.Name);
                    // else Console.WriteLine("    " + "    " + "Product not found");
                }

                { // ADD PRODUCT TO CART
                    Console.WriteLine("    " + "CART: ADD PRODUCT TO CART");
                    Product? product1 = new() { Id = "UNIFORM-001" };
                    product1 = userCart.AddProduct(product1);
                    if (product1 is not null)
                        Console.WriteLine("    " + "    " + $"ADD TO CART: {product1.Name}");
                    else Console.WriteLine("    " + "    " + "Product not found");
                    Product? product2 = new() { Id = "UNIFORM-002" };
                    product2 = userCart.AddProduct(product2);
                    if (product2 is not null)
                        Console.WriteLine("    " + "    " + $"ADD TO CART: {product2.Name}");
                    else Console.WriteLine("    " + "    " + "Product not found");
                }

                { // CHECK CART
                    Console.WriteLine("    " + "CART: CHECK CART");
                    foreach (Product item in userCart.Items) {
                        Console.WriteLine("    " + "    " + item.Name);
                    }
                }
                
                { // TOTAL PRICE
                    Console.WriteLine("    " + "CART: TOTAL PRICE");
                    Console.WriteLine("    " + "    " + userCart.TotalPrice());
                }

                { // REMOVE PRODUCT FROM CART
                    Console.WriteLine("    " + "CART: REMOVE PRODUCT FROM CART");
                    InventoryItem product = new() { Id = "UNIFORM-001" };
                    userCart.RemoveFromCart(product);
                }

                { // CHECK CART
                    Console.WriteLine("    " + "CART: CHECK CART");
                    foreach (Product item in userCart.Items) {
                        Console.WriteLine("    " + "    " + item.Name);
                    }
                }

                { // TOTAL PRICE
                    Console.WriteLine("    " + "CART: TOTAL PRICE");
                    Console.WriteLine("    " + "    " + userCart.TotalPrice());
                }
            }
        }
    }
}