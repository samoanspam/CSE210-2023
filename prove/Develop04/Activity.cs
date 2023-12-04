using System;

public abstract class Activity
{
    protected string Name;
    protected string Description;

    public void StartActivity()
    {
        Console.WriteLine($"Starting {Name} - {Description}");
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
        }
        Console.WriteLine();
    }

    protected abstract void PerformActivity();

    protected void FinishActivity()
    {
        int Duration = GetDuration();
        System.Console.WriteLine("Good job!");
        Countdown(3);
        System.Console.WriteLine($"You have completed {Name} for {Duration} seconds.");
        Countdown(3);
    }

    private int GetDuration()
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