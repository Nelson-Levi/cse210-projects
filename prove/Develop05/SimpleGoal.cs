public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, double pointAmount) : base (name, description, pointAmount)
    {}

    public override void CompleteGoal(User user)
    {
        IsCompleted = true;
        Console.WriteLine($"Congratulations! You have earned {PointAmount} points!");
        user.Points += PointAmount;
        user.CheckLevelUp();
    }

    public override void DisplayGoal()
    {
        // I use an inline if statement here. If IsCompleted is true, it will display the "X". Otherwise, it displays a whitespace.
        string goalString = $"[{(IsCompleted ? "X" :" ")}] {Name} ({Description})";
        Console.WriteLine(goalString);
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{Name},{Description},{PointAmount},{IsCompleted}";
    }
}