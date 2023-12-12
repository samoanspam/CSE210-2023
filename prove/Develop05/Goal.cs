using System;

public abstract class Goal
{
    private string name;
    private int value;
    private bool completed;

    public Goal(string name, int value)
    {
        this.name = name;
        this.value = value;
        this.completed = false;
    }

    public abstract void RecordEvent();

    public void DisplayStatus()
    {
        System.Console.WriteLine($"Goal '{name}' is {(completed ? "completed" : "not completed")}");
    }

    public string GetName()
    {
        return name;
    }

    public int GetValue()
    {
        return value;
    }

    public void MarkCompleted()
    {
        completed = true;
    }

    public bool IsCompleted()
    {
        return completed;
    }

    public virtual string GetProgress()
    {
        return "";
    }
}
