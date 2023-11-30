using System;

class Scripture
{
    private static List<Reference> _verses = new List<Reference>();
    private static bool _hidden = false;
    // private static string _scriptureVerse;

    public Scripture(List<string> verses)
    {
        // _scriptureVerse = scriptureVerse;
        foreach(string verseStr in verses)
        {
            Reference verse = new Reference(verseStr);
            _verses.Add(verse);
        }
        _hidden = false;
    }
    public static void Display()
    {
        // System.Console.WriteLine(_scriptureVerse);
        foreach (Reference verse in _verses)
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

            Reference verse = new Reference();
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
        foreach (Reference verse in _verses)
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
        foreach (Reference verse in _verses)
        {
            verse.ClearAll();
            _hidden = true;
        }
    }
}