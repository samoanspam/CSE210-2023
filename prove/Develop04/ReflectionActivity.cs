class ReflectionActivity : Activity
{
    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "Reflect on times in your life when you have shown strength and resilience. This activity is going to give you a prompt and itterate through a list of questions to push you to relfect on past events. ";
    }

    protected override void PerformActivity()
    {
        string[] reflectionPrompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };


        for (int i = 0; i < 1; i++)
        {
            string prompt = reflectionPrompts[i % reflectionPrompts.Length];
            Console.WriteLine(prompt);
            PauseWithSpinner(1);

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
                PauseWithSpinner(10);
            }
        }
        System.Console.WriteLine("Returning to main menu. ");
    }
}