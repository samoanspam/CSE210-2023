//Name: My Journal
//Purpose: The purpose of this program is to have the user(s) of the program be able to record thier impressions and feelings
//given unique prompts at random and then save it to a file for the user to access in the future. Also to delete all if in state of emergency.
//Team: Teia Patane
//Date: 10/6/2023

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Write a New Entry. ");
            Console.WriteLine("2. Display the Journal. ");
            Console.WriteLine("3. Save Journal to a file. ");
            Console.WriteLine("4. Delete the Journal. ");
            Console.WriteLine("5. Exit. ");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Entry.AddEntry();
            }
            else if (choice == "2")
            {
                Journal.DisplayJournal();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename: ");
                string fileName = Console.ReadLine();
                Journal.SaveJournal();
            }
            else if (choice == "4")
            {
                Journal.DeleteJournal();
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}