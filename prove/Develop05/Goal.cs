public abstract class Goal
{
    private bool _isCompleted = false;
    private string _name;
    private string _description;
    private double _pointAmount;

    public bool IsCompleted
    {
        get { return _isCompleted; }
        set { _isCompleted = value;}
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Description
    {
        get {return _description; }
        set { _description = value; }
    }

    public double PointAmount
    {
        get { return _pointAmount; }
        set { _pointAmount = value; }
    }

    public Goal(string name, string description, double pointAmount)
    {
        _name = name;
        _description = description;
        _pointAmount = pointAmount;
    }
        
    public abstract void CompleteGoal(User user);
    public abstract void DisplayGoal();
    public abstract string GetStringRepresentation();

    // I use a static method here because instances aren't going to utilize this method.
    public static Goal CreateGoalFromString(string goalType, string data)
    {
        // Split the string on the comma
        string[] details = data.Split(',');
        //[0] = name, [1] = description, [2] = pointAmount

        switch (goalType)
        {
            case "SimpleGoal":
            return new SimpleGoal(details[0], details[1], double.Parse(details[2]))
            {
                // IsCompleted isn't in the constructor, so I set it here.
                IsCompleted = bool.Parse(details[3])
            };

            case "EternalGoal":
            return new EternalGoal(details[0], details[1], double.Parse(details[2]));

            case "ChecklistGoal":
            // For ChecklistGoals, [3] = _goalTimes, and [4] = _bonusPoints
            return new ChecklistGoal(details[0], details[1], double.Parse(details[2]), int.Parse(details[3]), double.Parse(details[4]))
            {
                // TimesDone isn't in the constructor, so I set it here.
                TimesDone = int.Parse(details[5])
            };
        }
        return null;
    }
}