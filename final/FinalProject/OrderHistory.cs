using System;
using System.Collections.Generic;
using System.IO;

public class OrderHistory
{
    private List<Order> orders;
    private int nextOrderId;

    public OrderHistory()
    {
        orders = new List<Order>();
        nextOrderId = 1;
    }

    public int getNextOrderId()
    {
        return nextOrderId++;
    }

    public void addOrder(Order order)
    {
        order.Id = getNextOrderId();
        orders.Add(order);
    }

    public void displayOrderHistory()
    {
        System.Console.WriteLine("Order History:");
        System.Console.WriteLine();
        foreach (var order in orders)
        {
            order.displayDetails();
            System.Console.WriteLine("---------------------");
            System.Console.WriteLine();
        }
    }

    public void saveOrderToFile(Order order)
    {
        string fileName = $"Order_{order.Id}_{DateTime.Now:yyyyMMddHHmmss}.txt";
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine($"Order ID: {order.Id}");
            writer.WriteLine($"Order Date: {order.OrderDate}");
            writer.WriteLine("Customer Information:");
            writer.WriteLine($"Customer ID: {order.Customer.Id}");
            writer.WriteLine($"Name: {order.Customer.Name}");
            writer.WriteLine($"Email: {order.Customer.Email}");
            writer.WriteLine($"Address: {order.Customer.Address}");
            writer.WriteLine("Products in the order:");
            
            foreach (var product in order.Products)
            {
                writer.WriteLine($"Product ID: {product.Id}");
                writer.WriteLine($"Name: {product.Name}");
                writer.WriteLine($"Price: ${product.Price}");
            }
            writer.WriteLine($"Total Amount: ${order.TotalAmount}");
        }
        System.Console.WriteLine($"Order details saved to {fileName}");
        System.Console.WriteLine();
    }
}
