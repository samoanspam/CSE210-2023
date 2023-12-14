using System;
using System.Collections.Generic;

public class Order
{
    public int Id { get; set; }
    public Customer Customer { get; private set; }
    public List<Product> Products { get; private set; }
    public DateTime OrderDate { get; private set; }
    public double TotalAmount => calculateOrderTotal();

    public Order(int id, Customer customer, List<Product> products)
    {
        Id = id;
        Customer = customer;
        Products = products;
        OrderDate = DateTime.Now;
    }

    private double calculateOrderTotal()
    {
        double total = 0;
        foreach (var product in Products)
        {
            total += product.Price;
        }
        return total;
    }

    public void displayDetails()
    {
        System.Console.WriteLine($"Order ID: {Id}");
        System.Console.WriteLine();
        Customer.displayDetails();

        System.Console.WriteLine("Products in the order:");
        System.Console.WriteLine();
        foreach (var product in Products)
        {
            product.displayDetails();
        }

        System.Console.WriteLine($"Total Amount: ${TotalAmount}");
        System.Console.WriteLine();
        System.Console.WriteLine($"Order Date: {OrderDate}");
        System.Console.WriteLine();
    }
}
