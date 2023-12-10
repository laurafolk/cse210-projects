public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50.0 / 1000.0; // 50 meters per lap, converting to kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / (lengthInMinutes / 60.0);
    }

    public override double GetPace()
    {
        return lengthInMinutes / GetDistance();
    }
}
