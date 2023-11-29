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
            Console.WriteLine("Journal is empty!");
            Console.WriteLine();
        }

        foreach (Journal entry in journal)
        {
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine("Date: " + entry.Date);
            Console.WriteLine();
        }
    }


    static public void SaveJournal()
    {
        {
        Console.Write("Please enter a file name:");
        string fileName = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Journal entry in journal)
            {
                writer.WriteLine($"{entry.Date.ToString("yyyy-MM-dd")}|{entry.Prompt}|{entry.Response}");
            }
        }
        }
    }

// Reach file line by line, creates each Journal Object and adds it to list
static public void LoadJournal()
{
    Console.Write("Please enter the file name to load: ");
    string fileName = Console.ReadLine();

    journal.Clear(); // Clear existing entries

    string[] lines = File.ReadAllLines(fileName);
    foreach (string line in lines)
    {
        if (line == "" || line == null) continue; // Skip empty lines

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
    Console.WriteLine("Journal successfully loaded!");
    Console.WriteLine();
}

static public void DeleteJournal()
{
    // Prompt the user to enter the filename they want to clear.
    Console.Write("Enter the filename you want to clear: ");
    string fileName = Console.ReadLine();

    journal.Clear(); //Clear Journal

    // Check if the file exists before trying to clear it.
    if (File.Exists(fileName))
    {
        // Clears the contents of the file by writing an empty string to it.
        File.WriteAllText(fileName, String.Empty);
        Console.WriteLine("All contents of your Journal have been cleared.");
    }
    else
    {
        // Inform the user if the file does not exist.
        Console.WriteLine("File not found. Please make sure the filename is correct.");
    }
}

}