using System;

// Base Activity class: contains shared attributes and method signatures
public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    // Constructor to initialize date and length of the activity
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime Date
    {
        get { return _date; }
    }

    public int Minutes
    {
        get { return _minutes; }
    }

    // Abstract methods for derived classes to implement
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Provides a summary of the activity using polymorphism
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {this.GetType().Name} ({_minutes} min): " +
            $"Distance {GetDistance():0.0} km, " +
            $"Speed {GetSpeed():0.0} kph, " +
            $"Pace: {GetPace():0.00} min per km";
    }
}
