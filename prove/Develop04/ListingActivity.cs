class ListingActivity : Activity
{
    public ListingActivity()
    {
        // Nothing
    }

    public ListingActivity(int duration) : base("List", duration, "Welcome", "Ending", "peepeepoopoo")
    {

    }


    public void doIt()
    {
        PauseAnimation(3);
        System.Console.WriteLine("Hello");
        PauseAnimation(3);
    }
}