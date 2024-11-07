public class ListingActivity : Activity
{
    private List<string> _questions;
    private List<string> _inputs;
    private Random random = new Random();

    public ListingActivity()
    {
        Name = "Listing";
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _questions = new List<string>
        {
            "When did another person treat you with kindness this month?",
            "How did you show charity to your neighbors?",
            "What recent events are you grateful for?",
            "If you called your parents right now, what good news could you share with them?",
            "How have you seen the hand of the Lord in your life this week?"
        };
        _inputs = new List<string>{};
    }

    public void DisplayListingQuestion()
    {
        Console.Clear();
        int r = random.Next(_questions.Count);
        Console.WriteLine("List as many responses as you can to the following prompt: \n");
        Console.WriteLine($" ---{_questions[r]}--- \n");
        Console.WriteLine("You may begin in:");
        CountdownAnimation(5);
    }

    public void CollectResponses()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write($"> ");
            string input = Console.ReadLine();
            _inputs.Add(input);

            if (DateTime.Now >= endTime)
            {
                break;
            }
        }
        Console.WriteLine($"You listed {GetInputAmount()} items.\n");
    }

    public int GetInputAmount()
    {
        return _inputs.Count();
    }

    public void ExecuteListingActivity()
    {
        PrintStartMessage();
        DisplayListingQuestion();
        CollectResponses();
        PrintEndMessage();
    }
}