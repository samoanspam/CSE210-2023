class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "Relax by walking through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void PerformActivity()
    {
        string[] breatheInOutMessages = { "Breathe in...", "Breathe out..." };
        int duration = GetDuration();

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine(breatheInOutMessages[i % 2]);
            PauseWithSpinner(1);
        }
    }
}