using System;
using System.Security.Cryptography.X509Certificates;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _originalQuestions;
    private Random random = new Random();

    public ReflectingActivity()
    {
        Name = "Reflecting";
        Description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string> 
        {
        "Think of a time when you did something really difficult",
        "Remember a moment when you achieved something you initially thought was impossible",
        "Recall an experience that made you feel truly proud of yourself",
        "Think of a time when you overcame a fear"
        };
        _originalQuestions = new List<string>
        {
            "How did you feel when it was complete?",
            "What is your favorite thing about this experience?",
            "How has this moment impacted who you are today?",
            "What strengths did you discover within yourself in that moment?",
            "How did this experience shape your relationships with others?"
        };
        _questions = new List<string>(_originalQuestions);
    }

    public void DisplayPrompt()
    {
        int r = random.Next(_prompts.Count);
        Console.WriteLine("Consider the following prompt: \n");
        Console.WriteLine($" ---{_prompts[r]}--- \n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.\nYou may begin in:");
        CountdownAnimation(5);
    }

    public void DisplayQuestions()
    {
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            int r = random.Next(_questions.Count);
            Console.WriteLine($"> {_questions[r]}");
            RemoveQuestionFromList(r);
            if (_questions.Count == 0)
            {
                RestoreList();
            }
            LoadingAnimation();
        }
    }

    public void RemoveQuestionFromList(int index)
    {
        _questions.RemoveAt(index);
    }

    public void RestoreList()
    {
        _questions = new List<string>(_originalQuestions);
    }

    public void ExecuteReflectingActivity()
    {
        PrintStartMessage();
        DisplayPrompt();
        DisplayQuestions();
        PrintEndMessage();
    }
}