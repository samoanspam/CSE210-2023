using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("What is your favorite color? ");
        string color= Console.ReadLine();

        if (color == "red")
        {
            System.Console.WriteLine("That's my favorite color too! ");
        }
        else
        {
            System.Console.WriteLine("That's cool! ");
        }
    }
}