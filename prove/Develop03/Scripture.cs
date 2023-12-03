//Name: Scripture Memorizer
//Purpose: The purpose of this program is help the user to come closer to Chirst by helping them memorize a scripture that is near and dear to me.
//Team: Teia Patane
//Date: 12/3/2023

using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference ScriptureReference { get; private set; }
    private List<Word> Words;

    public Scripture(string text, Reference reference)
    {
        ScriptureReference = reference;
        // Put your input
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
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
    int wordsToHide = random.Next(1, Words.Count / 4); // Hiding up to 1/4th of the words

    int hiddenCount = 0;
    while (hiddenCount < wordsToHide)
    {
        int index = random.Next(Words.Count);
        if (!Words[index].IsHidden)
        {
            Words[index].IsHidden = true;
            hiddenCount++;
        }
        hiddenCount++;
    }
    //Eventually hides all words but doesn't currently check first if the words are hidden.
}
}