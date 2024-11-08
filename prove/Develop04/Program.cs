// For my stretch challenge, I added functionality to the Reflecting Activity so the same prompts could not be randomly selected again. After every prompt has been used, the list will repopulate and start all over. Additionally, I added functionality to log how many times each activity was selected.

// Websites I used for help:
// https://stackoverflow.com/questions/723211/quick-way-to-create-a-list-of-values-in-c
// https://stackoverflow.com/questions/2019417/how-to-access-random-item-in-list
// https://www.c-sharpcorner.com/UploadFile/mahesh/add-items-to-a-C-Sharp-list/
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.addrange?view=net-8.0

using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");

        // Initialize variables and objects
        int userSelection = 0;
        int activitiesCount = 0;
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();
        Console.WriteLine("Welcome to the Mindfulness Program!\nMenu Options:");

        // Display menu to user
        while (userSelection != 4)
        {
            Console.WriteLine("   1. Start breathing activity\n   2. Start reflecting activity\n   3. Start listing activity\n   4. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out userSelection))
            {
                // Switch case for menu selection.
                switch (userSelection)
                {
                    // Breathing Activity
                    case 1:
                        breathingActivity.ExecuteBreathingActivity();
                        activitiesCount ++;
                        breathingCount++;
                    break;

                    // Reflecting Activity
                    case 2:
                        reflectingActivity.ExecuteReflectingActivity();
                        activitiesCount++;
                        reflectingCount++;
                        break;

                    // Listing Activity
                    case 3:
                        listingActivity.ExecuteListingActivity();
                        activitiesCount++;
                        listingCount++;
                        break;

                    // Quit
                    case 4:
                        Console.WriteLine("Thank you for using the mindfulness program.");
                        Console.WriteLine("Here are your results! ");
                        Console.WriteLine($"You completed {activitiesCount} activities.\nYou completed the Breathing Activity {breathingCount} time(s). You completed the Reflecting Activity {reflectingCount} time(s). You completed the Listing Activity {listingCount} time(s).");
                        break;
                    
                    default:
                        Console.WriteLine("You entered an invalid option. Please enter a number from 1-4. ");
                        break;
                }
            }

            else
            {
                Console.WriteLine("You entered an invalid option. Please enter a number from 1-4. ");
            }
        }
    }
}