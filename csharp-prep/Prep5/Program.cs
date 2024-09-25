using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcomeMessage();
        string userName = PromptUserName();
        float number = PromptUserNumber();
        float square = SquareNumber(number);
        DisplayResult(userName, square);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: "); 
        string username = Console.ReadLine();
        return username;
    }

    static float PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string numberInput = Console.ReadLine();
        float floatInput = float.Parse(numberInput);
        return floatInput;
    }

    static float SquareNumber(float integer)
    {
        float square = integer * integer;
        return square;
    }

    static void DisplayResult(string name, float square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }

}