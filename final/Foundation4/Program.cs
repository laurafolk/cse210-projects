using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 3.0));
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 4.8));
        activities.Add(new StationaryBicycle(new DateTime(2022, 11, 3), 45, 15.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 4), 40, 20));

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}