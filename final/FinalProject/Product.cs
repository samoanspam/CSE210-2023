using System;

public class Product
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(int id, string name, double price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public void displayDetails()
    {
        System.Console.WriteLine($"Product ID: {Id}");
        System.Console.WriteLine();
        System.Console.WriteLine($"Name: {Name}");
        System.Console.WriteLine();
        System.Console.WriteLine($"Price: ${Price}");
        System.Console.WriteLine();
    }
}
