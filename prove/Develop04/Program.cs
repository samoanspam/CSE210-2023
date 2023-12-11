using System;
using System.Linq;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Select an activity: ");
            Console.WriteLine("1. Breathing Activity ");
            Console.WriteLine("2. Listing Activity ");
            Console.WriteLine("3. Reflection Activity ");
            Console.WriteLine("4. Exit");
        
            int choice;

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                System.Console.WriteLine("Invalid input. Please enter a number");
                continue;
            }

            switch (choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.StartActivity();
                    break;
                case 2:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.StartActivity();
                    break;
                case 3:
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.ReflectionStartActivity();
                    break;
                case 4:
                    System.Console.WriteLine("Thank you for participating! Goodbye. ");
                    Environment.Exit(0);
                    break;
                default:
                    System.Console.WriteLine("Invalid choice. Please select a valid option");
                    break;
            }
        }
    }
}
//TODO:
//Fix all "i loops", get rid of unecessary countdowns, make it more pretty  X
//Add a limit/random list to reflection activity X
//Change parameters to listing activity X
//Fix edge case in main menu X