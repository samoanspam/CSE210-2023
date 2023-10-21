using System;

class Scripture
{
    private static List<Verse> _verses = new List<Verse>();
    private static bool _hidden = false;
    // private static string _scriptureVerse;

    public Scripture(List<string> verses)
    {
        // _scriptureVerse = scriptureVerse;
        foreach(string verseStr in verses)
        {
            Verse verse = new Verse(verseStr);
            _verses.Add(verse);
        }
        _hidden = false;
    }
    public static void Display()
    {
        // System.Console.WriteLine(_scriptureVerse);
        foreach (Verse verse in _verses)
        {
            verse.Display();
        }

    }

    public static bool HideWords(int count)
    {
        int number = 0;
        int counter = 0;
        while (number < count)
        {
            Random random = new Random();
            int index = random.Next(_verses.Count());

            Verse verse = new Verse();
            verse = _verses[index];

            if (verse.HideWord() == true)
            {
                number += 1;
            }
            counter += 1;
            if (counter > 100)
            {
                _hidden = true;

                return false;
            }
        }

        return true;
    }

    public static bool IsAllHidden()
    {
        foreach (Verse verse in _verses)
        {
            if (verse.IsAllHidden() == false)
            {
                return false;
            }
        }

        return true;
    }

    public void ClearAll()
    {
        foreach (Verse verse in _verses)
        {
            verse.ClearAll();
            _hidden = true;
        }
    }
}