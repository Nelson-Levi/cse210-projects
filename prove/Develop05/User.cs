public class User
{
    private List<Goal> _goals = new List<Goal>();
    private double _points = 0;
    private int _level = 0;

    public List<Goal> Goals
    {
        get { return _goals; }
        set { _goals = value; }
    }

    public double Points
    {
        get { return _points; }
        set { _points = value; }
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"You have {_points} points and are Level {_level}.");
    }

    public void CheckLevelUp()
    {
        // I have to add a tiny amount to _level here. Otherwise, because it starts at 0, and anything times 0 is going to be 0... you'll never level up!
        // If the amount of points is greater than or equal to level times 100, then call the LevelUp() method. 
        if (_points >= (_level + .1) * 100)
        {
            LevelUp();
        }
    }

    public void LevelUp()
    {
        int originalLevel = _level;
        // Making it an integer forces it to become a whole number.
        _level = (int)(Points / 100);
        int gainedLevels = _level - originalLevel;
        Console.WriteLine($"Congratulations! You gained {gainedLevels} level(s)! You are now Level {_level}. ");
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            outputfile.WriteLine($"{_points},{_level}");
            foreach (Goal goal in _goals)
            {
                outputfile.WriteLine(goal.GetStringRepresentation());
            }
            // Flush out buffered data.
            outputfile.Flush();
            // Display file location.
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine($"File saved at location: {currentDirectory}\\{filename}");
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string [] lines = System.IO.File.ReadAllLines(filename);

            string[] userDetails = lines[0].Split(',');
            _points = int.Parse(userDetails[0]);
            _level = int.Parse(userDetails[1]);

            // For every remaining line...
            for (int i = 1; i < lines.Length; i++)
            {
                // Split on the colon
                string[] parts = lines[i].Split(':');
                // First half is the goalType
                string goalType = parts[0];
                // Second half is all the data
                string goalData = parts[1];

                Goal newGoal = Goal.CreateGoalFromString(goalType, goalData);
                _goals.Add(newGoal);
            }
            Console.WriteLine($"Goals loaded from {filename}.");       
        }
    }
}