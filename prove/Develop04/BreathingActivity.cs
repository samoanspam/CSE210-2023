class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Name = "Breathing Activity";
        Description = "Relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void PerformActivity()
    {
        string[] breatheInOutMessages = { "Breathe in...", "Breathe out..." };
        int duration = GetDuration();

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine(breatheInOutMessages[i % 2]);
            PauseWithSpinner(3); // Pause for 3 seconds between messages
        }
    }

    private int GetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        return int.Parse(Console.ReadLine());
    }
}