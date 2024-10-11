using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _journalInput;
    public string _dateText;
    public string _selectedPrompt;
    public string _completedEntry;

    // Its a smart idea to make lists with a new List class :)
    public List<string> _prompts = new List<string> {
    "Who was the most interesting person you interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"
    };
    public List<string> _completedEntries = new List<string> {};

    // call the random class, set a variable name, then set it equal to a new initiation of the Random() class
    static Random random = new Random();

    public void journalEntry()
    {
        // Integer randomly decided. It can only go as high as the amount of strings in the _prompts list!
        // This allows you to add prompts without affecting functionality
        int _randomIndex = random.Next(_prompts.Count);
        // Randomly select a prompt.
        _selectedPrompt = _prompts[_randomIndex];
        Console.WriteLine(_selectedPrompt);
        Console.Write("> ");
        _journalInput = Console.ReadLine();
        // Save the current DateTime as a string.
        _dateText = DateTime.Now.ToShortDateString();
        // Save the completed entry as a string.
        _completedEntry = $"{_dateText} - Prompt: {_selectedPrompt} \n {_journalInput}";
        // Add the completed entry to the total list of entries.
        _completedEntries.Add(_completedEntry);
    }

    public void journalDisplay()
    {
        foreach (string entry in _completedEntries)
        {
            // Display each completed entry one by one.
            Console.WriteLine(entry);
        }
    }
}