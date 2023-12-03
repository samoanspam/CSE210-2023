using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

public class Scripture
{
    public Reference ScriptureReference { get; private set; }
    private List<Word> Words;

    public Scripture(string text, Reference reference)
    {
        ScriptureReference = reference;
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
        
        // This is a shorthand of the above.
        // string[] splitText = text.Split(' ');
        // Words = new List<Word>();
        // foreach (string wordText in splitText)
        // {
        //     Word word = new Word(wordText);
        //     Words.Add(word);
        // }
    }

    public void DisplayScripture()
    {
        Console.WriteLine(ScriptureReference.ToString());
        Console.WriteLine(string.Join(" ", Words.Select(w => w.ToString())));
    }

    public void HideRandomWords()
    {
    Random random = new Random();
    int wordsToHide = random.Next(1, Words.Count / 4);

    if (AreAllWordsHidden())
    {
        Console.WriteLine("All words are now hidden. Goodbye. ");
        Console.WriteLine();
        Environment.Exit(0);
    };

    int hiddenCount = 0;
    while (hiddenCount < wordsToHide)
    {
        if (AreAllWordsHidden())
        {
            break;
        }
        int index = random.Next(Words.Count);
        if (!Words[index].IsHidden)
        {
            Words[index].IsHidden = true;
            hiddenCount++;
        }
    }
    }

    private bool AreAllWordsHidden()
    {
        foreach (Word word in Words)
        {
           if (!word.IsHidden)
           {
            return false;
           }
        }
        return true;
    }
}