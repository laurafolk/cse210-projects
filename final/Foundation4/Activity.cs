using System;
using System;

public class Activity
{
    private DateTime date;
    protected int lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        this.date = date;
        this.lengthInMinutes = lengthInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0; // Default implementation, to be overridden in derived classes
    }

    public virtual double GetSpeed()
    {
        return 0; // Default implementation, to be overridden in derived classes
    }

    public virtual double GetPace()
    {
        return 0; // Default implementation, to be overridden in derived classes
    }

    public string GetSummary()
    {
        return $"{date:dd MMM yyyy} {GetType().Name} ({lengthInMinutes} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
