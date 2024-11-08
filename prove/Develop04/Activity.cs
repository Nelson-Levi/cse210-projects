using System;

public class Activity
{
    private int _duration = 0;
    private string _description;
    private string _name;

    // Allow other classes to access and write these private attributes
    public string Name
    {
        get { return _name; }
        set { _name = value;}
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    // Base constructor
    public Activity()
    {
        _name = "Activity";
        _description = "Description";
    }

    public void LoadingAnimation()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);
        int i = 0;

        List<string> animationStrings = new List<string>();
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void CountdownAnimation(int length)
    {
        while (length > 0)
        {
            Console.Write(length);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            length--;
        }
    }

    public void PrintStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n{_description}\nHow long, in seconds, would you like for your session? ");
        string durationString = Console.ReadLine();
        int durationInt = int.Parse(durationString);
        SetDuration(durationInt);
        Console.Clear();
        Console.WriteLine("Get ready...");
        LoadingAnimation();
    }

    public void PrintEndMessage()
    {
        Console.WriteLine("Well done!");
        LoadingAnimation();
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
        LoadingAnimation();
        Console.Clear();
    }

    public void SetDuration(int newDuration)
    {
        _duration = newDuration;
    }

    public int GetDuration()
    {
        return _duration;
    }
}