//Name: Scripture Memorizer
//Purpose: The purpose of this program is help the user to come closer to Chirst by helping them memorize a scripture that is near and dear to me.
//Team: Teia Patane
//Date: 10/20/2023

using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> verses = new List<string>
        {
            "Mosiah Chapter 3 Verse 19",
            "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth ", 
            "off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all ",
            "things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father"
        };

        // Random number of words chosen randomly from each row at random. 
        Random random = new Random();
        int number = random.Next(1,4);

        Scripture scripture = new Scripture(verses);
        Scripture.Display();
        Scripture.HideWords(number);
        Scripture.IsAllHidden();
    }
}