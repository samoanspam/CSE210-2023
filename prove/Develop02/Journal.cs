using System;
using System.IO;

class Journal
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
    public static string JournalFile = "Journal.txt";

    public static List<Journal> journal = new List<Journal>();

        public static void DisplayJournal()
    {
        foreach (Journal entry in journal)
        {
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine("Date: " + entry.Date);
        }
    }

    static public void SaveJournal()
    {
        // foreach (string entry in journal)
        {
            File.AppendAllText(JournalFile, "test");
        }
    }


    static public void DeleteJournal()
    {
        File.WriteAllText(JournalFile, String.Empty);
        System.Console.WriteLine("All contents of your Journal has been cleared. ");
    }
}
