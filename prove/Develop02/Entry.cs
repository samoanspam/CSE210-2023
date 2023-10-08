using System;
using System.IO;

class Entry
{
        static public void AddEntry()
    {
        string prompt = Prompt.GetPrompt();

        Console.Write(prompt + " ");
        string response = Console.ReadLine();
        
        Journal entry = new Journal
        {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now
        };

        Journal.journal.Add(entry);
    }
}