public class EternalGoal : Goal
{
    private int bonusPoints;

    public EternalGoal(string name, int value, int bonusPoints) : base(name, value)
    {
        this.bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        System.Console.WriteLine($"Event recorded for eternal goal '{GetName()}'.");
        ApplyBonus();
    }

    public void ApplyBonus()
    {
        System.Console.WriteLine($"Bonus of {bonusPoints} points applied for eternal goal '{GetName()}'.");
    }
}
