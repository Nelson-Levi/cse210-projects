using System;
// Must use System.Collections.Generic if you have lists!
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        // Declare a variable to hold the user's input
        int userInput = -1;

        // Declare a variable for the number checker
        int checkNumber = int.MaxValue;
        
        // Create a list to store the numbers that the user enters
        List<int> ints = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished. Try both positive and negative numbers! ");

        // Start a loop that will continue until the user inputs 0
        while (userInput != 0)
        {
            Console.Write("Enter number: ");
            
            // Read the user's input AS A STRING
            string intString = Console.ReadLine();
            
            // Convert the string input to an integer
            userInput = int.Parse(intString);

            // Add the number to the list if it is not 0. IF I DON'T USE THIS, THEN THE 0 IS ADDED TO THE LIST
            if (userInput != 0) 
            {
                ints.Add(userInput);
                // Check if the userInput is smaller than the checkNumber and positive
                if (userInput < checkNumber && userInput >= 0)
                {
                    // If true, userInput becomes the new checkNumber
                    // Put checkNumber FIRST before userInput! That way, the value of checkNumber is changed, not the other way around :)
                    checkNumber = userInput;
                }
            }
        }

        // Find the sum, average, and highest number in the list
        int sum = ints.Sum();
        int length = ints.Count;
        // Calculate the average by dividing the sum by the count
        // I make it a float to avoid integer division, which would mess up the decimal
        float average = (float)sum / length;
        int highest = ints.Max();

        // I use the Sort method to sort the list
        ints.Sort();

        // Display the results to the user
        Console.WriteLine($"The sum of all numbers is {sum}.");
        Console.WriteLine($"The average of all numbers is {average}.");
        Console.WriteLine($"The highest number is {highest}.");
        Console.WriteLine($"The smallest positive number is {checkNumber}.");

        // Use a foreach loop to display each number in order.
        Console.WriteLine($"Here are the numbers in order:");
        foreach (int number in ints) 
        {
            Console.Write($"{number} ");
        }
    }
}
