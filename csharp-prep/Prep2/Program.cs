using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is your grade percentage? ");
        string gradeInput = Console.ReadLine();
        int grade = int.Parse(gradeInput);
        string letterGrade = "";

        int lastDigit = grade % 10;
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