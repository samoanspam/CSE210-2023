public class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    //TODO: Check how long word is
    //replace each letter with underscore
    public override string ToString()
    {
        return IsHidden ? "____" : Text;

        //Above is shorthand for this
        // if (IsHidden) {
        //     return "_____";
        // }
        // else {
        //     return Text;
        // }
    }
}