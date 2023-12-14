using System;
using System.Collections.Generic;
public class ShoppingCart
{
    private List<Product> products;

    public ShoppingCart()
    {
        products = new List<Product>();
    }

    public void addToCart(Product product)
    {
        products.Add(product);
        System.Console.WriteLine($"{product.Id} added to the cart.");
        System.Console.WriteLine();
    }

    public void removeFromCart(Product product)
    {
        products.Remove(product);
        System.Console.WriteLine($"{product.Id} removed from the cart.");
        System.Console.WriteLine();
    }

    public void viewCart()
    {
        System.Console.WriteLine("Shopping Cart:");
        System.Console.WriteLine();
        foreach (var product in products)
        {
            System.Console.WriteLine($"{product.Id} - ${product.Price} - {product.Name}");
            System.Console.WriteLine();
        }
        System.Console.WriteLine($"Total: ${calculateTotal()}");
        System.Console.WriteLine();
    }

    private double calculateTotal()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.Price;
        }
        return total;
    }

    public List<Product> getCartContents()
    {
        return new List<Product>(products); // Return a copy to avoid direct manipulation
    }

    public void clearCart()
    {
        products.Clear();
        System.Console.WriteLine("Shopping cart cleared.");
        System.Console.WriteLine();
    }
}
