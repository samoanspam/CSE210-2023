//Name: Scripture Memorizer
//Purpose: The purpose of this program is to help the user simply navigate the complex idea of grocery shopping in a safe and easy environment.
//Team: Teia Patane
//Date: 12/13/2023

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static List<User> users = new List<User>();
    static List<Product> products = new List<Product>();

    static void Main()
    {
        initializeProducts();

        users.Add(new User(1, "user1", "password1"));
        users.Add(new User(2, "user2", "password2"));

        Customer regularCustomer = new Customer(1, "Alice", "alice@email.com", "123 Main St");

        OrderHistory orderHistory = new OrderHistory();

        ShoppingCart cart = new ShoppingCart();


        while (true)
        {
            System.Console.WriteLine("Welcome to the Peabody Market!");
            System.Console.WriteLine();
            System.Console.WriteLine("1. View Cart");
            System.Console.WriteLine();
            System.Console.WriteLine("2. Add Product to Cart");
            System.Console.WriteLine();
            System.Console.WriteLine("3. Checkout");
            System.Console.WriteLine();
            System.Console.WriteLine("4. View Order History");
            System.Console.WriteLine();
            System.Console.WriteLine("5. Add New Customer");
            System.Console.WriteLine();
            System.Console.WriteLine("6. Exit");
            System.Console.WriteLine();
            System.Console.Write("Please select an option: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        cart.viewCart();
                        break;

                    case 2:
                        displayAvailableProducts();
                        System.Console.Write("Enter the product ID to add to the cart: ");
                        System.Console.WriteLine();
                        if (int.TryParse(Console.ReadLine(), out int productId))
                        {
                            Product selectedProduct = getProductById(productId);
                            if (selectedProduct != null)
                            {
                                cart.addToCart(selectedProduct);
                            }
                            else
                            {
                                System.Console.WriteLine("Invalid product ID.");
                                System.Console.WriteLine();
                            }
                        }
                        else
                        {
                            System.Console.WriteLine("Invalid input.");
                            System.Console.WriteLine();
                        }
                        break;

                    case 3:
                        Order currentOrder = new Order(orderHistory.getNextOrderId(), regularCustomer, cart.getCartContents());
                        orderHistory.addOrder(currentOrder);
                        cart.clearCart();
                        System.Console.WriteLine("Checkout successful!");
                        System.Console.WriteLine();
                        orderHistory.saveOrderToFile(currentOrder);
                        break;

                    case 4:
                        orderHistory.displayOrderHistory();
                        break;

                    case 5:
                        addNewCustomer();
                        break;

                    case 6:
                        System.Console.WriteLine("Thank you for shopping at Peabody Market. Goodbye!");
                        System.Console.WriteLine();
                        return;

                    default:
                        System.Console.WriteLine("Invalid choice. Please try again.");
                        System.Console.WriteLine();
                        break;
                }
            }
            else
            {
                System.Console.WriteLine("Invalid input. Please enter a number.");
                System.Console.WriteLine();
            }
        }
    }

static void initializeProducts()
    {
        products.Add(new Product(1, "Laptop", 999.99));
        products.Add(new Product(2, "Smartphone", 599.99));
        products.Add(new Product(3, "Headphones", 79.99));
        products.Add(new Product(4, "Tablet", 299.99));
        products.Add(new Product(5, "Camera", 449.99));
    }

    static void displayAvailableProducts()
    {
        System.Console.WriteLine("Available Products:");
        System.Console.WriteLine();
        foreach (var product in getAllProducts())
        {
            product.displayDetails();
        }
    }

    static List<Product> getAllProducts()
    {
        return products;
    }

    static Product getProductById(int productId)
    {
        return getAllProducts().FirstOrDefault(p => p.Id == productId);
    }

    static void addNewCustomer()
    {
        System.Console.Write("Enter customer name: ");
        string name = Console.ReadLine();
        System.Console.Write("Enter customer email: ");
        string email = Console.ReadLine();
        System.Console.Write("Enter customer address: ");
        string address = Console.ReadLine();

        Customer newCustomer = new Customer(users.Count + 1, name, email, address);

        System.Console.WriteLine($"New customer added with ID: {newCustomer.Id}");
        System.Console.WriteLine();
    }
}

//TODO:
/* 
- adding list of users
- "sign in" to choose which user
- load a file to "view past order history"
- display user's details
- add to the menu each of these features
- Add "loading" animation everywhere
*/