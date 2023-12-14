using System;

public class User
{
    public int Id { get; private set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public User(int id, string username, string password)
    {
        Id = id;
        Username = username;
        Password = password;
    }

    public void displayDetails()
    {
        System.Console.WriteLine($"User ID: {Id}");
        System.Console.WriteLine();
        System.Console.WriteLine($"Username: {Username}");
        System.Console.WriteLine();
    }
}
