class BreathingActivity : Activity
{
    private string _welcomeMessage = "Welcome to the Breathing Activity";
    private string _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing. ";
    public BreathingActivity()
    {
        // Nothing
    }

    public BreathingActivity(int duration) : base("Breath", duration, "Welcome", "Ending", "peepeepoopoo")
    {

    }


    public void doIt()
    {
        PauseAnimation(3);
        System.Console.WriteLine("Hello");
        PauseAnimation(3);
    }
}