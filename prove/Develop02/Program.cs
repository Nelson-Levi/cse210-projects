// Additions to exceed requirements:
// * Added functionality to display file location when a file is saved.
// * Calculated and saved the time spent writing each journal entry. This displays alongside each entry.

// Websites I used for help:
// https://www.tutorialspoint.com/how-to-select-a-random-element-from-a-chash-list
// https://stackoverflow.com/questions/24443827/reading-an-integer-from-user-input
// https://learn.microsoft.com/en-us/dotnet/api/system.io.filestream.flush?view=net-8.0
// https://stackoverflow.com/questions/1026841/how-to-get-only-time-from-date-time-c-sharp
// https://learn.microsoft.com/en-us/dotnet/api/system.datetime.toshorttimestring?view=net-8.0&redirectedfrom=MSDN#System_DateTime_ToShortTimeString
// https://www.c-sharpcorner.com/blogs/timespan-in-c-sharp

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
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save \n5. Quit");
            Console.Write("What would you like to do? ");
            string input = Console.ReadLine();

            // Try parsing the input to an integer
            if (int.TryParse(input, out userSelection))
            {
                switch (userSelection)
                {
                    // Write
                    case 1:
                        entry.JournalEntry();
                        break;

                    // Display
                    case 2:
                        entry.JournalDisplay();
                        break;

                    // Load
                    case 3:
                        Console.WriteLine("Enter a file to load. ");
                        string loadingFile = Console.ReadLine();
                        journal.LoadFile(loadingFile, entry);
                        break;

                    // Save
                    case 4:
                        Console.WriteLine("Enter a filename to save entries:");
                        string filename = Console.ReadLine();
                        journal.SaveFile(entry._completedEntries, filename);
                        break;

                    // End program
                    case 5:
                        Console.WriteLine("Thank you for using the journal program. Have a great day!\n");
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