class ListingActivity : Activity
{
    public ListingActivity()
    {
        Name = "Listing Activity";
        Description = "Reflect on the good things in your life by listing items in a certain area.";
    }

    protected override void PerformActivity()
    {
        string[] listingPrompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        int duration = GetDuration();

        for (int i = 0; i < duration; i++)
        {
            string prompt = listingPrompts[i % listingPrompts.Length];
            Console.WriteLine(prompt);
            Countdown(5); // Countdown for 5 seconds to begin thinking about the prompt
            Console.WriteLine("Keep listing items...");

            int itemsCount = 0;
            string input;
            do
            {
                input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    itemsCount++;
                }
            } while (!string.IsNullOrWhiteSpace(input));

            Console.WriteLine($"You listed {itemsCount} items.");
            FinishActivity();
        }
    }

    private int GetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        return int.Parse(Console.ReadLine());
    }
}