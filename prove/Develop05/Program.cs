using System;

class Program
{
    static void Main()
    {
        User user = new User();

        while (true)
        {
            System.Console.WriteLine("Welcome to our Goal Program, please enjoy!");
            System.Console.WriteLine("Main Menu:");
            System.Console.WriteLine("1. Create a Goal");
            System.Console.WriteLine("2. Record an Event");
            System.Console.WriteLine("3. Display all Goals");
            System.Console.WriteLine("4. Display user Score");
            System.Console.WriteLine("5. Exit");
            System.Console.Write("Enter your choice (1-5): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        CreateGoal(user);
                        break;
                    case 2:
                        RecordEvent(user);
                        break;
                    case 3:
                        user.DisplayGoals();
                        break;
                    case 4:
                        user.DisplayScore();
                        break;
                    case 5:
                        System.Console.WriteLine("Thank you for using our Goal Program, goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        System.Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
            else
            {
                System.Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    static void CreateGoal(User user)
    {
        System.Console.WriteLine("\nSelect the goal type:");
        System.Console.WriteLine("1. Simple Goal");
        System.Console.WriteLine("2. Eternal Goal");
        System.Console.WriteLine("3. Checklist Goal");
        System.Console.Write("Enter your choice (1-3): ");

        if (int.TryParse(Console.ReadLine(), out int goalType))
        {
            System.Console.Write("Enter the goal name: ");
            string name = Console.ReadLine();

            System.Console.Write("Enter the goal value: ");
            if (int.TryParse(Console.ReadLine(), out int value))
            {
                switch (goalType)
                {
                    case 1:
                        System.Console.Write("Enter bonus points for simple goal: ");
                        if (int.TryParse(Console.ReadLine(), out int bonusPoints))
                        {
                            Goal simpleGoal = new SimpleGoal(name, value, bonusPoints);
                            user.CreateGoal(simpleGoal);
                        }
                        else
                        {
                            System.Console.WriteLine("Invalid input for bonus points. Goal creation failed.");
                        }
                        break;
                    case 2:
                        System.Console.Write("Enter bonus points for eternal goal: ");
                        if (int.TryParse(Console.ReadLine(), out int eternalBonusPoints))
                        {
                            Goal eternalGoal = new EternalGoal(name, value, eternalBonusPoints);
                            user.CreateGoal(eternalGoal);
                        }
                        else
                        {
                            System.Console.WriteLine("Invalid input for bonus points. Goal creation failed.");
                        }
                        break;
                    case 3:
                        System.Console.Write("Enter target count for checklist goal: ");
                        if (int.TryParse(Console.ReadLine(), out int targetCount))
                        {
                            Goal checklistGoal = new ChecklistGoal(name, value, targetCount);
                            user.CreateGoal(checklistGoal);
                        }
                        else
                        {
                            System.Console.WriteLine("Invalid input for target count. Goal creation failed.");
                        }
                        break;
                    default:
                        System.Console.WriteLine("Invalid goal type. Goal creation failed.");
                        break;
                }
            }
            else
            {
                System.Console.WriteLine("Invalid input for goal value. Goal creation failed.");
            }
        }
        else
        {
            System.Console.WriteLine("Invalid input. Please enter a number.");
        }
    }

    static void SaveGoals(User user)
    {
        user.SaveGoals();
    }
    static void RecordEvent(User user)
    {
        if (user.goals.Count == 0)
        {
            System.Console.WriteLine("No goals available. Please create a goal first.");
            return;
        }

        System.Console.WriteLine("Select a goal to record an event:");
        for (int i = 0; i < user.goals.Count; i++)
        {
            System.Console.WriteLine($"{i + 1}. {user.goals[i].GetName()}");
        }

        if (int.TryParse(Console.ReadLine(), out int selectedGoalIndex) && selectedGoalIndex >= 1 && selectedGoalIndex <= user.goals.Count)
        {
            Goal selectedGoal = user.goals[selectedGoalIndex - 1];
            user.RecordEvent(selectedGoal);
            SaveGoals(user); // Save goals after recording an event
        }
        else
        {
            System.Console.WriteLine("Invalid input. Recording event failed.");
        }
    }
}
