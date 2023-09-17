using System;
class Program
{
    static void Main(string[] args)
    {
        int x = 5;
        int y = 4;
        string name;

        System.Console.WriteLine("What is your name? ");

        name = Console.ReadLine();

        if (name == "John")
        {
            System.Console.WriteLine("Great name! ");
        } 
        else
        {
            System.Console.WriteLine("That's a cool name! ");
        }


        if (x > y)
        {
            System.Console.WriteLine("greater than y");
        }
        if (x < y)
        {
            System.Console.WriteLine("greater than x");
        }
        else
        {
            System.Console.WriteLine("less than both");
        }
    }
}