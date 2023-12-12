using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


public class User
{
    private int score;
    public List<Goal> goals;

    public User()
    {
        score = 0;
        goals = new List<Goal>();
        LoadGoals(); // Load existing goals when the user is created
    }

    public void CreateGoal(Goal goal)
    {
        goals.Add(goal);
        System.Console.WriteLine($"Goal '{goal.GetName()}' created for the user.");
        SaveGoals(); // Save goals after creating a new one
    }

    public void RecordEvent(Goal goal)
    {
        goal.RecordEvent();
        UpdateScore(goal.GetValue());
        DisplayScore();
        SaveGoals(); // Save goals after recording an event
    }

    public void DisplayScore()
    {
        System.Console.WriteLine($"User's total score: {score} points");
    }

    private void UpdateScore(int points)
    {
        score += points;
    }

    public void DisplayGoals()
    {
        System.Console.WriteLine("\nUser's Goals:");
        foreach (var goal in goals)
        {
            System.Console.Write($"- {goal.GetName()} ({goal.GetValue()} points): ");
            goal.DisplayStatus();
            System.Console.WriteLine($"   Progress: {goal.GetProgress()}");
        }
    }
    
    private void LoadGoals()
    {
        try
        {
            if (File.Exists("goals.txt"))
            {
                goals.Clear(); // Clear existing goals before loading new ones

                foreach (string line in File.ReadAllLines("goals.txt"))
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 4)
                    {
                        string goalType = parts[0].Trim();
                        string name = parts[1].Trim();
                        int value = int.Parse(parts[2].Trim());
                        int bonus = int.Parse(parts[3].Trim());

                        Goal goal;
                        switch (goalType)
                        {
                            case "SimpleGoal":
                                goal = new SimpleGoal(name, value, bonus);
                                break;
                            case "EternalGoal":
                                goal = new EternalGoal(name, value, bonus);
                                break;
                            case "ChecklistGoal":
                                goal = new ChecklistGoal(name, value, bonus);
                                break;
                            default:
                                System.Console.WriteLine($"Unknown goal type: {goalType}");
                                continue; // Skip this line and move to the next one
                        }

                        goals.Add(goal);
                    }
                    else
                    {
                        System.Console.WriteLine($"Invalid line format: {line}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Error loading goals: {ex.Message}");
        }
    }

    public void SaveGoals()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter("goals.txt"))
            {
                foreach (Goal goal in goals)
                {
                    string goalType = goal.GetType().Name;
                    string line = $"{goalType} | {goal.GetName()} | {goal.GetValue()} | {GetBonusForSaving(goal)}";
                    writer.WriteLine(line);
                }
            }
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Error saving goals: {ex.Message}");
        }
    }

    private int GetBonusForSaving(Goal goal)
    {
        // This method should be adjusted based on the specific requirements of each goal type
        // For simplicity, it returns a constant bonus here
        return 100;
    }
}
