public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, double pointAmount) : base(name, description, pointAmount)
    {}

    public override void CompleteGoal(User user)
    {
        Console.WriteLine($"Congratulations! You have earned {PointAmount} points!");
        user.Points += PointAmount;
        user.CheckLevelUp();
    }

    public override void DisplayGoal()
    {
        string goalString = $"[ ] {Name} ({Description})";
        Console.WriteLine(goalString);
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{Name},{Description},{PointAmount}";
    }
}