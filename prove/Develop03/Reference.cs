public class Reference
{
    public string Book { get; set; }
    public int Chapter { get; set; }
    public int StartVerse { get; set; }
    public int? EndVerse { get; set; } // Nullable for single verse references

    // Constructor for single verse
    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = verse;
    }

    // Constructor for a range of verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        return EndVerse.HasValue ? $"{Book} {Chapter}:{StartVerse}-{EndVerse}" : $"{Book} {Chapter}:{StartVerse}";

        //Above is shorthand for this
        // if (EndVerse.HasValue) {
        //     return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
        // }
        // else {
        //     return $"{Book} {Chapter}:{StartVerse}";
        // }
    }
}