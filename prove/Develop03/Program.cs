using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1 = new Scripture("For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.", new Reference("John", 3, 16));
        Scripture scripture2 = new Scripture("In the beginning was the Word, and the Word was with God, and the Word was God.", new Reference("John", 1, 1));
        Scripture scripture3 = new Scripture("Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.", new Reference("John", 3, 5));
        Scripture scripture4 = new Scripture("If ye love me, keep my commandments.", new Reference("John", 14, 15));

        List<Scripture> scripturesList = new List<Scripture>();
        
        scripturesList.Add(scripture1);
        scripturesList.Add(scripture2);
        scripturesList.Add(scripture3);
        scripturesList.Add(scripture4);

        Random random = new Random();
        
        Scripture scripture = scripturesList[random.Next(0, scripturesList.Count())] ;
        

        while (true)
        {
            Console.Clear();
            scripture.DisplayScripture();

            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine();

            // Edge case: if user types something other than 'quit' what will happen?
            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Good luck next time! Goodbye!");
                break;
            }

            scripture.HideRandomWords();
        }
    }
}