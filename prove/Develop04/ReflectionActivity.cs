class ReflectionActivity : Activity
{
    public ReflectionActivity()
    {
        Name = "Reflection Activity";
        Description = "Reflect on times in your life when you have shown strength and resilience.";
    }

    protected override void PerformActivity()
    {
        string[] reflectionPrompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        int duration = GetDuration();

        for (int i = 0; i < duration; i++)
        {
            string prompt = reflectionPrompts[i % reflectionPrompts.Length];
            Console.WriteLine(prompt);
            PauseWithSpinner(3); // Pause with spinner for 3 seconds

            string[] reflectionQuestions = {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            };

            foreach (var question in reflectionQuestions)
            {
                Console.WriteLine(question);
                PauseWithSpinner(2); // Pause with spinner for 2 seconds
            }
        }
    }
    private int GetDuration()
    {
        Console.Write("Enter the duration of the activity in seconds: ");
        return int.Parse(Console.ReadLine());
    }
}