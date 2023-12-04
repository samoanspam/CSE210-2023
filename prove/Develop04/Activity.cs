using System;

public abstract class Activity
{
    protected string _name;
    protected string _description;

    public void StartActivity()
    {
        Console.WriteLine($"Starting {_name} - {_description}");
        PrepareToBegin();
    }

    protected void PrepareToBegin()
    {
        System.Console.WriteLine();
        Countdown(3);
        PerformActivity();
        FinishActivity();
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}...");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void PauseWithSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
            i++;
        }
        Console.WriteLine();
    }

    protected abstract void PerformActivity();

    protected void FinishActivity()
    {
        int duration = GetDuration();
        System.Console.WriteLine("Good job!");
        Countdown(3);
        System.Console.WriteLine($"You have completed {_name} for {duration} seconds.");
        Countdown(3);
    }

    public int GetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        return int.Parse(Console.ReadLine());
    }
/*     public void PauseAnimation(int delay)
    {
        int timer = 1;
        double time = delay;
        while (time > 0)
        {
            Console.Write("\\");
            
            Thread.Sleep(500);

            time -= timer;
            Console.Write("\b\b");
            Console.Write("/");

            Thread.Sleep(500);

            Console.Write("\b\b");   
        }
    } */
}