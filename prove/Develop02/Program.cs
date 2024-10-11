// Websites I used for help:
// https://www.tutorialspoint.com/how-to-select-a-random-element-from-a-chash-list
// https://stackoverflow.com/questions/24443827/reading-an-integer-from-user-input

using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        int userSelection = 0;
        Console.WriteLine("Welcome to the journal program! ");

        // You should initialize these outside of the loop.
        Entry entry = new Entry();
        Journal journal = new Journal();
        
        while (userSelection != 5)
        {
            Console.WriteLine("Please select one of the following choices. ");
            Console.WriteLine(" 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
            string input = Console.ReadLine();
            
            // Try parsing the input to an integer
            if (int.TryParse(input, out userSelection))
            {
                switch (userSelection)
                {
                    // Write
                    case 1:
                    entry.journalEntry();
                    break;

                    // Display
                    case 2:
                    entry.journalDisplay();
                    break;

                    // Load
                    case 3:
                    Console.WriteLine("Enter a file to load. ");
                    string loadingFile = Console.ReadLine();
                    journal.loadFile(loadingFile, entry);
                    break;

                    // Save
                    case 4:
                    Console.WriteLine("Enter a filename to save entries:");
                    string filename = Console.ReadLine();
                    journal.saveFile(entry._completedEntries, filename);
                    break;

                    // End program
                    case 5:
                    Console.WriteLine("Thank you for using the journal program. Have a great day! ");
                    break;

                    default:
                    Console.WriteLine("You entered an invalid option. Please enter a number from 1-5. ");
                    break;
                }
            }

            else
            {
                Console.WriteLine("You entered an invalid option. Please enter a number from 1-5. ");
            }
        }
    }
}