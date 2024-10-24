// Websites I used for help:

// https://learn.microsoft.com/en-us/dotnet/api/system.string.isnullorempty?view=net-8.0
// https://www.geeksforgeeks.org/c-sharp-list-class/
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/method-parameters
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/where-clause

// For my stretch challenges, I added functionality so my program doesn't hide words that are already hidden. Additionally, I added functionality so the program will only hide the words themselves and not the punctuation.

using System;

class Program
{
    static void Main(string[] args)
    {

        Reference reference = new Reference("Proverbs", "3", "5", "6");
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
        string userInput = "";

        while (!scripture.AreAllWordsHidden() && userInput != "quit")
        {
            Console.WriteLine(scripture.GetFullScripture());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type \"quit\" to quit. ");
            userInput = Console.ReadLine();
            Console.Clear();

            scripture.HideRandomWords();
        }

        Console.WriteLine("Thanks for using the scripture memorizing program.");
    }
}