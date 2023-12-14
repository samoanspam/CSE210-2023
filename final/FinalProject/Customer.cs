using System;

public class Customer
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }

    public Customer(int id, string name, string email, string address)
    {
        Id = id;
        Name = name;
        Email = email;
        Address = address;
    }

    //Send in a User object to parse through and display details.
    public void displayDetails()
    {
        System.Console.WriteLine($"Customer ID: {Id}");
        System.Console.WriteLine();
        System.Console.WriteLine($"Name: {Name}");
        System.Console.WriteLine();
        System.Console.WriteLine($"Email: {Email}");
        System.Console.WriteLine();
        System.Console.WriteLine($"Address: {Address}");
        System.Console.WriteLine();
    }
}
