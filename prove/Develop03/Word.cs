using System;

class Word
{
    private string _text;
    private bool _hidden = false;

    public Word()
    {
        // Blank Constructor
    }
    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    public void Display()
    {
        if (_hidden == true)
        {
            foreach (char c in _text)
            {
                Console.Write('_');
            }
            
        } else {
            Console.Write(_text);
        }
        
    }

    public bool IsHidden()
    {
        return _hidden;
    }

    public void Clear()
    {
        _hidden = true;
    }
}