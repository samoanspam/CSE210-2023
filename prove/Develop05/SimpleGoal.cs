public class SimpleGoal : Goal
{
    private int bonusPoints;

    public SimpleGoal(string name, int value, int bonusPoints) : base(name, value)
    {
        this.bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        System.Console.WriteLine($"Event recorded for simple goal '{GetName()}'.");
        MarkCompleted();
        ApplyBonus();
    }

    public void ApplyBonus()
    {
        System.Console.WriteLine($"Bonus of {bonusPoints} points applied for completing simple goal '{GetName()}'.");
    }
}
