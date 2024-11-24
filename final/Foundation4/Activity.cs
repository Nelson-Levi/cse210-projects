using System.Configuration.Assemblies;
using System.Runtime.InteropServices.Marshalling;

public abstract class Activity
{
    private string _date;
    private double _lengthMinutes;

    public string Date
    {
        get { return _date; }
        set { _date = value; }
    }
    public double LengthMinutes
    {
        get { return _lengthMinutes; }
        set { _lengthMinutes = value; }
    }

    public Activity(string date, double lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public string GetSummary()
    // Format like this: 03 Nov 2022 Running (30 min) - Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
    {
        return $"{_date} ({_lengthMinutes} min) - Distance {CalculateDistance()} miles, Speed {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile";
    }

}