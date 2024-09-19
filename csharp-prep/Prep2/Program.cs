using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user to input their grade percentage
        Console.WriteLine("What is your grade percentage? ");
        // Read the user's input AS A STRING
        string gradeInput = Console.ReadLine();
        // Convert the string input to an integer (assuming the input is a valid number)
        int grade = int.Parse(gradeInput);
        // Variable to hold the letter grade, initialized as an empty string
        string letterGrade = "";

        // Calculate the last digit of the grade for determining the sign
        int lastDigit = grade % 10;
        // Again, initialize the variable with an empty string
        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";
        }

        else if (lastDigit <= 3)
        {
            sign = "-";
        }


        if (grade >= 90)
        {
            letterGrade = "A";

            if (sign == "+") sign = "";
        }

        else if (grade >= 80)
        {
            letterGrade = "B";
        }

        else if (grade >= 70)
        {
            letterGrade = "C";
        }

        else if (grade >= 60)
        {
            letterGrade = "D";
        }

        else
        {
            letterGrade = "F";
            sign = "";
        }

        Console.WriteLine($"You have a {letterGrade}{sign} in this class. ");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You are passing the class! ");
        }

        else
        {
            Console.WriteLine("You are not passing. Try again next semester! ");
        }
    }
}