class ReflectionActivity : Activity
{
    public ReflectionActivity()
    {
        // Nothing
    }

    public ReflectionActivity(int duration) : base("Reflect", duration, "Welcome", "Ending", "peepeepoopoo")
    {

    }


    public void doIt()
    {
        PauseAnimation(3);
        System.Console.WriteLine("Hello");
        PauseAnimation(3);
    }
}