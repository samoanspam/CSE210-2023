using System;
using System.Reflection;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main(string[] args)
    {
        string firstName;
        string lastName;
        Console.WriteLine("What is your first name? ");
        firstName = Console.ReadLine();
        
        Console.WriteLine("What is your last name? ");
        lastName = Console.ReadLine();

        System.Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}. ");
    }
}