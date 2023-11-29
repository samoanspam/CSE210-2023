using System;
using System.IO;

class Prompt
{
        static List<string> prompts = new List<string> {
        "How did you serve someone today? ",
        "Did you come closer to Christ? ",
        "What's something you would have changed from today? ",
        "What do you plan on doing this weekend? ",
        "What did you study in your scriptures today? "
    };

        static public string GetPrompt()
        {
            
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(prompts.Count);
        string prompt = prompts[index];

        return prompt;
        }
}