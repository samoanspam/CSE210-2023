using System;
using System.IO;

class Journal
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }

    public static List<Journal> journal = new List<Journal>();

    public static void DisplayJournal()
    {
        if(journal.Count == 0){
            System.Console.WriteLine("Journal is empty!");
            System.Console.WriteLine();
        }

        foreach (Journal listing in journal)
        {
            System.Console.WriteLine("Prompt: " + listing.Prompt);
            System.Console.WriteLine("Response: " + listing.Response);
            System.Console.WriteLine("Date: " + listing.Date);
            System.Console.WriteLine();
        }
    }


    static public void SaveJournal()
    {
        {
        Console.Write("Please enter a file name:");
        string fileName = Console.ReadLine();

        // I don't know what "using" does or StreamWriter object/class
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Journal entry in journal)
            {
                writer.WriteLine($"{entry.Date.ToString("yyyy-MM-dd")}|{entry.Prompt}|{entry.Response}");
            }
        }
        }
    }

static public void LoadJournal()
{
    Console.Write("Please enter the file name to load: ");
    string fileName = Console.ReadLine();

    journal.Clear(); // Clear existing entries

    string[] lines = File.ReadAllLines(fileName);
    foreach (string line in lines)
    {
        if (line == "" || line == null) continue;
    // Possible edge case if user uses "|" in entry
        string[] parts = line.Split('|');
        
        if (parts.Length == 3) // Ensure there are three parts
        {
            Journal entry = new Journal
            {
                Date = DateTime.Parse(parts[0]),
                Prompt = parts[1],
                Response = parts[2]
            };
            journal.Add(entry);
        }
    }
    System.Console.WriteLine("Journal successfully loaded!");
    System.Console.WriteLine();
}

static public void DeleteJournal()
{
    Console.Write("Enter the filename you want to clear: ");
    string fileName = Console.ReadLine();

    journal.Clear(); //Clear Journal

    if (File.Exists(fileName))
    {
        // Clears the contents of the file by writing an empty string to it.
        File.WriteAllText(fileName, String.Empty);
        System.Console.WriteLine("All contents of your Journal have been cleared.");
    }
        //Not using a while loop to check for fileName because it'll force you to delete if accidental input,
        //
    else
    {
        System.Console.WriteLine("File not found. Please make sure the filename is correct.");
    }
}

}