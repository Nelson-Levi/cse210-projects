using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        Console.Write("What is your first name? "); // Use Console.Write, NOT Console.Writeline for user input
        string firstName = Console.ReadLine(); // Define the variable type, then set it equal to the Console.ReadLine function

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}. "); // Display the results to the user, using $ for string interpolation
        
    }
}