public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string date, double length, int laps) : base (date, length)
    {
        _laps = laps;
    }

    public override double CalculateDistance()
    {
        return Math.Round(_laps * 50 / 1000 * 0.62, 1);
    }

    public override double CalculateSpeed()
    {
        return Math.Round(CalculateDistance() / LengthMinutes * 60, 1);
    }

    public override double CalculatePace()
    {
        return Math.Round(LengthMinutes / CalculateDistance(), 1);
    }
}