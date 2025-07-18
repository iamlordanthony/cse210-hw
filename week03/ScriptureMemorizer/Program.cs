// ---------------------------------------------------------------------------
// Scripture Memorizer Program
// Author: Lord Anthony Senanu
// Date: 18th July 2025
// Description: This program helps users memorize scripture by hiding words
// from a verse or verses until the entire scripture is hidden.
// 
// Exceeding Requirements:
// - Added support for loading a random scripture from a file containing
//   multiple scriptures. Each time the program runs, a different scripture
//   may be selected.
// - Ensured that only words that are not already hidden are selected for
//   hiding each round, making the hiding process more intelligent.
// - Enhanced the display formatting to wrap lines nicely in the console
//   for better readability.
//
// ---------------------------------------------------------------------------

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program ending.");
                break;
            }
        }
    }
}
