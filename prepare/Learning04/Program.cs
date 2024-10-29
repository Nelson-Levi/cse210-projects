using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment assignment = new Assignment("Levi Nelson", "Computer Science");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Cory Tillet", "Math 150x", "Section 7.3", "Problems 10-15");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WrittenAssignment writtenAssignment = new WrittenAssignment("True Herbert", "American History", "The Revolutionary War");
        Console.WriteLine(writtenAssignment.GetSummary());
        Console.WriteLine(writtenAssignment.GetWritingInformation());
    }
}