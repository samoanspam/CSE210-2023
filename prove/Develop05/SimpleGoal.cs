class SimpleGoal : Goal
{
    private int bonusPoints;

    public SimpleGoal(string name, int value, int bonusPoints) : base(name, value)
    {
        this.bonusPoints = bonusPoints;
    }

    public void ApplyBonus()
    {
        System.Console.WriteLine($"Bonus of {bonusPoints} points applied for completing simple goal '{GetName()}'. ");

    }
}