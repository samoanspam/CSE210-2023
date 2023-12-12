using System;
using System.Data;

class Program
{
    static void Main()
    {
        //Creating a new user
        User user = new User();
        
        while (true)
        {
            System.Console.WriteLine("Welcome to the Goal Program!");
            System.Console.WriteLine();
            System.Console.WriteLine("Main Menu:");
            System.Console.WriteLine("1. Create a Goal");
            System.Console.WriteLine("2. Record an Event");
            System.Console.WriteLine("3. Display all Goals");
            System.Console.WriteLine("4. Display user Score");
            System.Console.WriteLine("5. Exit");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        CreateGoal();
                        break;
                    case 2:
                        RecordEvent();
                        break;
                    case 3:
                        DisplayGoals();
                        break;
                    case 4:
                        DisplayScore();
                        break;
                    case 5:
                        System.Console.WriteLine("Thank you for using our program, goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        System.Console.WriteLine("Invalid Choice. Please enter a valid choice between 1-5.");
                        break;                                                                                                                    
                }
            }
        }
    }
}