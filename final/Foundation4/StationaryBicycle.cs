public class StationaryBicycle : Activity
{
    private double speed;

    public StationaryBicycle(DateTime date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetPace()
    {
        // Pace is not applicable for stationary bicycle
        return 0;
    }
}
