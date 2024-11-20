public class ChecklistGoal : Goal
{
    private int _goalTimes;
    private double _bonusPoints;
    private int _timesDone = 0;

    public int TimesDone
    {
        get { return _timesDone;}
        set { _timesDone = value; }
    }


    public ChecklistGoal(string name, string description, double pointAmount, int goalTimes, double bonusPoints) : base(name, description, pointAmount)
    {
        _goalTimes = goalTimes;
        _bonusPoints = bonusPoints;
    }

    public void IncrementTimes()
    {
        _timesDone ++;
    }

    public override void DisplayGoal()
    {
        // I use an inline if statement here. If IsCompleted is true, it will display the "X". Otherwise, it displays a whitespace.
        string goalString = $"[{(IsCompleted ? "X" :" ")}] {Name} ({Description}) --- Currently completed: {_timesDone}/{_goalTimes} ";
        Console.WriteLine(goalString);
    }

    public override void CompleteGoal(User user)
    {
        IncrementTimes();
        if (_goalTimes == _timesDone)
        {
            Console.WriteLine($"Congratulations! You have earned {PointAmount + _bonusPoints} points!");
            IsCompleted = true;
            double totalPoints = _bonusPoints + PointAmount;
            user.Points += totalPoints;
            user.CheckLevelUp();
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {PointAmount} points!");
            user.Points += PointAmount;
            user.CheckLevelUp();
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Name},{Description},{PointAmount},{_goalTimes},{_bonusPoints},{_timesDone}";
    }

}