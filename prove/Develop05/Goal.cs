class Goal
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

    public void RecordEvent()
    {
        completed = true;
        System.Console.WriteLine($"Event recorded for goal '{name}'. ");
    }

    public void DisplayStatus()
    {
        System.Console.WriteLine($"Goal '{name}' is {(completed ? "completed. " : "not completed. ")}");
    }

    public string GetName()
    {
        return name;
    }

    public int GetValue()
    {
        return value;
    }
}