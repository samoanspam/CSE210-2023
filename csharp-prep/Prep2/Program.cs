using System;
class Program
{
    static void Main(string[] args)
    {
        int x = 5;
        int y = 4;
        string name;
        int number1;
        int number2;

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


        System.Console.WriteLine("Give me a number");
        number1 = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Give me another number");
        number2 = Convert.ToInt32(Console.ReadLine());

        if (number1 > number2)
        {
            System.Console.WriteLine("Your first number is greater than the second. ");
        }
        else if (number1 < number2)
        {
            System.Console.WriteLine("Your second number is greater than the first. ");
        }
        else
        {
            System.Console.WriteLine("I don't know about this one... ");
        }
    }
}