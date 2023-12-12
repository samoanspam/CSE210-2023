public class ChecklistGoal : Goal
{
    private int targetCount;
    private int currentCount;

    public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
    {
        this.targetCount = targetCount;
        this.currentCount = 0;
    }

    public override void RecordEvent()
    {
        System.Console.WriteLine($"Event recorded for checklist goal '{GetName()}'.");
        UpdateCount();
    }

    public void UpdateCount()
    {
        currentCount++;
        System.Console.WriteLine($"Updated count for checklist goal '{GetName()}': {currentCount}/{targetCount} times.");

        if (currentCount == targetCount)
        {
            System.Console.WriteLine($"Bonus applied for completing checklist goal '{GetName()}': {GetBonus()} points.");
            MarkCompleted();
        }
    }

    private int GetBonus()
    {
        return 500; // Bonus points specific to checklist completion
    }

    public override string GetProgress()
    {
        return $"Completed {currentCount}/{targetCount} times";
    }
}
