namespace FalconShop;

public class Terminal {
    public static void TerminalInterface(string[] args) {
        Console.Title = "Falcon Shop";
        while (true) {
            Console.Clear();
            Console.WriteLine("Welcome to Falcon Shop!");
            Console.WriteLine();
            Console.Write("[Enter] Login | [R] Register | [Q] Quit ");
            var input = Console.ReadKey();
            Console.Clear();
            switch (input.Key) {
                case ConsoleKey.Enter:
                    Login(args);
                    break;
                case ConsoleKey.R:
                    Register();
                    break;
                case ConsoleKey.Q:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    continue;
            }
        }
    }

    static void MainMenu() {
        Console.WriteLine("Welcome to Falcon Shop!");
        Console.WriteLine();
        Console.WriteLine("Main Menu");
        Console.WriteLine("[1] View products");
        Console.WriteLine("[2] View cart");
        Console.WriteLine("[3] Checkout");
        Console.WriteLine("[E] Exit (Log out)");
        Console.WriteLine();
        while (true) {
            ConsoleKeyInfo choice = Console.ReadKey();
            if (choice.Key == ConsoleKey.D1) Console.WriteLine("PROTOTYPE VIEW PRODUCTS");
            else if (choice.Key == ConsoleKey.D2) Console.WriteLine("PROTOTYPE VIEW CART");
            else if (choice.Key == ConsoleKey.D3) Console.WriteLine("PROTOTYPE CHECKOUT");
            else if (choice.Key == ConsoleKey.E) break;
            else {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }
        }
    }

    static void Login(string[] args) {
        while (true) {
            Console.WriteLine("Login to Falcon Shop");
            Console.WriteLine();

            string username;
            string password;

            if (args.Length == 2) {
                username = args[0];
                password = args[1];
            }
            else {
                Console.Write("Enter username: ");
                username = Console.ReadLine()!;
                Console.Write("Enter password: ");
                password = Console.ReadLine()!;
            }

            var authenticate = Authenticator.Authenticate(username, password);

            if (authenticate) MainMenu();
            else {
                Console.Write("Invalid credentials. Try again? [y/N] ");
                var choice = Console.ReadLine()!;
                choice = choice.ToUpper();
                if (choice == "Y") continue;
            }

            break;
        }
    }

    static void Register() {
        Console.WriteLine("Register to Falcon Shop");
        Console.WriteLine();
        Console.WriteLine("[1] Register as Customer");
        Console.WriteLine("[2] Register as Student");
        Console.WriteLine("[3] Register as Staff");
        Console.WriteLine("[4] Register as Admin");
        Console.WriteLine("[E] Exit to Main Menu");
        Console.WriteLine();
        while (true) {
            ConsoleKeyInfo cki = Console.ReadKey();
            ConsoleKey registerType = cki.Key;
            {
                if (registerType == ConsoleKey.E) break;
                else if (registerType != ConsoleKey.D1 &&
                         registerType != ConsoleKey.D2 &&
                         registerType != ConsoleKey.D3 &&
                         registerType != ConsoleKey.D4) {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }
                else Console.Clear();
            }
            string userType = registerType switch {
                ConsoleKey.D1 => "Customer",
                ConsoleKey.D2 => "Student",
                ConsoleKey.D3 => "Staff",
                ConsoleKey.D4 => "Admin",
                _ => "Customer"
            };


            Account user = new Account(userType);

            {
                Console.WriteLine($"Register to Falcon Shop as {user.Type}");
                Console.WriteLine();
                Console.Write("Enter your first name: ");
                user.Forename = Console.ReadLine()!;
                Console.Write("Enter your last name: ");
                user.Surname = Console.ReadLine()!;
                Console.Write("Enter your middle name (enter to skip): ");
                user.MiddleName = Console.ReadLine();
                Console.Write($"Enter {user.Type} ID: ");
                user.Id = Console.ReadLine()!;

                Console.WriteLine();
                Console.WriteLine($"Hey there, {user.FullName}! Let's create your account.");
                Console.WriteLine();
                Console.Write("Enter your username: ");
                user.Username = Console.ReadLine()!;
                Console.Write("Enter your password: "); // TODO: Mask password input
                user.Password = Console.ReadLine()!;
                Console.Write("Enter your email (enter to skip): ");
                user.Email = Console.ReadLine();

                Console.WriteLine();

                {
                    if (user.Type is "Admin" or "Staff") {
                        Console.WriteLine($"Approve {user.Type} account");
                        Console.Write("Enter admin username: ");
                        var username = Console.ReadLine()!;
                        Console.Write("Enter admin password: ");
                        var password = Console.ReadLine()!;
                        var authenticate = Authenticator.Authenticate(username, password);
                        if (authenticate is false) {
                            Console.WriteLine("Invalid credentials. Please try again.");
                            Console.WriteLine();
                            continue;
                        }
                    }
                }

                {
                    Console.WriteLine();
                }

                if (Account.Validate(user) is true) {
                    Console.WriteLine("Account created successfully!");
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}