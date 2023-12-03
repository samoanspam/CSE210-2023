using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.", new Reference("John", 3, 16));

        while (true)
        {
            Console.Clear();
            scripture.DisplayScripture();

            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            // Edge case: if user types something other than 'quit' what will happen?
            if (input.ToLower() == "quit")
                break;

            //if all are hidden then quit
            scripture.HideRandomWords();


        }
    }
}