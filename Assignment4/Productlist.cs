using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{

    class Product
    {
        private string pcode;
        public string pname;
        public int qty_in_stock;
        public double discount_allowed;
        public static string brand = "Amazon";
        public double price;

        public Product(string code, string name, int stock, double discount, double price)
        {
            pcode = code;
            pname = name;
            qty_in_stock = stock;
            discount_allowed = discount;
            this.price = price;
        }

        public void TakeInputFromAdmin()
        {
            Console.Write("Enter product name: ");
            pname = Console.ReadLine();

            Console.Write("Enter quantity in stock: ");
            qty_in_stock = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter discount allowed (%): ");
            discount_allowed = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter price per unit: ");
            price = Convert.ToDouble(Console.ReadLine());
        }

        public void Display()
        {

            Console.WriteLine("Product Code     : " + pcode);
            Console.WriteLine("Product Name     : " + pname);
            Console.WriteLine("Quantity in Stock: " + qty_in_stock);
            Console.WriteLine("Discount Allowed : " + discount_allowed + "%");
            Console.WriteLine("Price per Unit   : $" + price);
            Console.WriteLine("Brand            : " + brand);

        }

        public string GetCode()
        {
            return pcode;
        }
    }

    class ProductList
    {
        // 🔁 Initialize 5 products using list initializer
        static List<Product> products = new List<Product>
    {
        new Product("P001", "Laptop", 10, 5, 50000),
        new Product("P002", "Headphones", 20, 10, 2000),
        new Product("P003", "Smartphone", 15, 7.5, 25000),
        new Product("P004", "Charger", 50, 0, 499),
        new Product("P005", "Keyboard", 25, 5, 899)
    };

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nWho are you?");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Customer");
                Console.WriteLine("3. Exit");
                Console.Write("Enter choice: ");
                string roleChoice = Console.ReadLine();

                if (roleChoice == "1")
                {
                    AdminMenu();
                }
                else if (roleChoice == "2")
                {
                    CustomerMenu();
                }
                else if (roleChoice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
        }

        static void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine("\n Admin Menu ");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. Display All Products");
                Console.WriteLine("3. Back");
                Console.Write("Enter choice: ");
                string adminChoice = Console.ReadLine();

                if (adminChoice == "1")
                {
                    Console.Write("Enter unique product code: ");
                    string pcode = Console.ReadLine();

                    Product p = new Product(pcode, "", 0, 0, 0);
                    p.TakeInputFromAdmin();
                    products.Add(p);
                    Console.WriteLine("Product added successfully!");
                }
                else if (adminChoice == "2")
                {
                    Console.WriteLine("\n--- All Products ---");
                    foreach (var p in products)
                    {
                        p.Display();
                    }
                }
                else if (adminChoice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
        }

        static void CustomerMenu()
        {
            Console.Write("\nEnter product name to order: ");
            string name = Console.ReadLine();

            Product selectedProduct = null;
            foreach (var p in products)
            {
                if (p.pname.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    selectedProduct = p;
                    break;
                }
            }

            if (selectedProduct == null)
            {
                Console.WriteLine("Product not found.");
                return;
            }

            selectedProduct.Display();

            Console.Write("Enter quantity to purchase: ");
            int qty = Convert.ToInt32(Console.ReadLine());

            if (qty > selectedProduct.qty_in_stock)
            {
                Console.WriteLine("Not enough stock available.");
                return;
            }

            double originalTotal = selectedProduct.price * qty;
            double discountAmount = (originalTotal * selectedProduct.discount_allowed) / 100;
            double finalAmount = originalTotal - discountAmount;

            DateTime today = DateTime.Now;

            if (today.Month == 1 && today.Day == 26)
            {
                finalAmount = originalTotal * 0.5;
                Console.WriteLine("Republic Day Discount (50%) Applied!");
            }
            else
            {
                Console.WriteLine($"Product Discount ({selectedProduct.discount_allowed}%) Applied: ₹{discountAmount}");
            }

            Console.WriteLine("\n--- Bill ---");
            Console.WriteLine("Product Name      : " + selectedProduct.pname);
            Console.WriteLine("Quantity Purchased: " + qty);
            Console.WriteLine("Unit Price        : $" + selectedProduct.price);
            Console.WriteLine("Original Total    : $" + originalTotal);
            Console.WriteLine("Final Amount To Pay: $" + finalAmount);
            Console.WriteLine("Thank you for shopping!");

            selectedProduct.qty_in_stock -= qty;
        }
    }

}
