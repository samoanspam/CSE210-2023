using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Select an activity: ");
            Console.WriteLine("1. Breathing Activity ");
            Console.WriteLine("2. Reflection Activity ");
            Console.WriteLine("3. Listing Activity ");
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
                    reflectionActivity.StartActivity();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    System.Console.WriteLine("Invalid choice. Please select a valid option");
                    break;
            }
        }
    }
}