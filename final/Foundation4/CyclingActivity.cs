public class CyclingActivity : Activity
{
    private double _speed;
    public CyclingActivity(string date, double lengthMinutes, double speed) : base (date, lengthMinutes)
    {
        _speed = speed;
    }

    public override double CalculateDistance()
    {
        return Math.Round(LengthMinutes * CalculateSpeed() / 60, 2);
    }

    public override double CalculateSpeed()
    {
        return Math.Round(_speed, 2);
    }

    public override double CalculatePace()
    {
        return Math.Round(LengthMinutes / CalculateDistance(), 2);
    }
}