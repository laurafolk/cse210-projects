using System;
using System.Threading;
using System.Collections.Generic;
// Breathing Activity Class
public class BreathingActivity : Activity
{
    private string _description;

    public BreathingActivity(string activity, int duration, string description)
        : base(activity, duration)
    {
        _description = description;
    }
    public void BreatheInBreatheOutAnimation(int breatheInDuration, int holdDuration, int breatheOutDuration)
    {
        Console.WriteLine("Breathe in for " + breatheInDuration + " seconds...");

        // Count down from 5 to 0 to breathe in.
        //for (int i = 5; i >= 0; i--) keeping just in case
        for (int i = breatheInDuration; i >= 0; i--)
        {
            Console.WriteLine("Count: " + i);
            // Simulate animation duration (e.g., 1000 milliseconds)
            System.Threading.Thread.Sleep(1000);
            Console.Clear(); // Clear the console for the next count
        }

        Console.WriteLine("Hold your breath for 5 " + holdDuration + " seconds...");
        // Pause for 5 seconds (5000 milliseconds)
        System.Threading.Thread.Sleep(holdDuration * 1000);

        Console.WriteLine("Breathe out for " + breatheOutDuration + " seconds...");

        // Count down from 7 to 0 for "breathe out"
        for (int i = breatheOutDuration; i >= 0; i--)
        //for (int i = 7; i >= 0; i--) keeping just in case needed again.
        {
            Console.WriteLine("Count: " + i);
            // Simulate animation duration (e.g., 1000 milliseconds)
            System.Threading.Thread.Sleep(1000);
            Console.Clear(); // Clear the console for the next count
        }
    }
    //Keep the below in case the replacement below it does not work right.
    public void ShowBreathingInMessage(int duration, int holdDuration)
    {
        for (int i = 5; i >= 0; i--)
        {
            Console.WriteLine($"{i} seconds left");
            Thread.Sleep(1000);
        }

    Thread.Sleep(holdDuration * 1000);

    }
    public void ShowBreathingOutMessage(int duration, int holdDuration)
    {
        for (int i = 7; i >= 0; i--)
        {
            Console.WriteLine($"{i} seconds left");
            Thread.Sleep(1000);
        }

        Thread.Sleep(duration * 1000);
    }

    public new void RunActivity()
    {
        base.RunActivity();
        Console.WriteLine(_description);

        Console.WriteLine($"Enter the hold duration (in seconds): ");
            int holdDuration = int.Parse(Console.ReadLine());

        //    ShowBreathingInMessage(_duration, holdDuration);
        //    ShowBreathingOutMessage(_duration, holdDuration);
        //}
    }
}
