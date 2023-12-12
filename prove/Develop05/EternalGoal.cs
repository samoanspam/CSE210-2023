class EternalGoal : Goal
{
    private int frequency;
    private int bonusMultiplier;

    public EternalGoal(string name, int value, int frequency, int bonusMultiplier) : base(name, value)
    {
        this.frequency = frequency;
        this.bonusMultiplier = bonusMultiplier;
    }

    public void CalculatePoints()
    {
        int points = frequency * bonusMultiplier;
        Console.WriteLine($"Calculated {points} points for eternal goal '{GetName()}'.");
    }
}
