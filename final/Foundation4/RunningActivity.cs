public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, double lengthMinutes, float distance) : base(date, lengthMinutes)
    {
        _distance = distance;
    }

    public override double CalculateDistance()
    {
        return Math.Round(_distance, 2);
    }

    public override double CalculateSpeed()
    {
        return Math.Round(CalculateDistance() / LengthMinutes * 60);
    }

    public override double CalculatePace()
    {
        return Math.Round(LengthMinutes / CalculateDistance());
    }
}