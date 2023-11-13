using System;
using System.Threading;
using System.Collections.Generic;
// Base Activity Class
public class Activity
{
    protected string _name;
    //protected int _duration;
    protected int _durationInSeconds;
    private string _description;

    public Activity(string activity, int duration)
    {
        _name = activity;
        _durationInSeconds = duration;
    }

    public void Welcome()
    {
        Console.WriteLine("Welcome to " + _name + "!");
    }

    public void Description()
    {
        Console.WriteLine("Description: " + _name);
    }
    public void DurationQuestion()
    {
        Console.WriteLine("How long would you like to do " + _name + "?(" + _durationInSeconds + " seconds)");
    }

    protected void ShowCountDownTimer()//(int seconds)
    {
        for (int i = _durationInSeconds; i >= 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
    protected void SpinnerAnimation()
    {
        string[] spinners = { "|", "/", "-", "\\" };
        for (int i = 0; i < _durationInSeconds; i++)
        {
            Console.Write($"Spinning: {spinners[i % spinners.Length]}\r");
            Thread.Sleep(100); // Adjust the speed of the spinner here
        }
        Console.WriteLine(); // Clear the spinner animation
    }

    public void DotsAppearingAnimation()
    {
        // Implement dots appearing animation
    }

    public void GetReady()
    {
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(2000);
    }

    //public void WellDone()
    //{
    //    Console.WriteLine("Well done!");
        //Thread.Sleep(2000);
    //}
    public void RunActivity()
    {
        Welcome();
        Description();
        DurationQuestion();
        GetReady();
        SpinnerAnimation();
        //CountDown(5); //The duration gets changed as needed.
        //WellDone();

        Console.WriteLine("Do you want to quit? (Y/N)");
        string quitChoice = Console.ReadLine();
        if (quitChoice.ToUpper() == "Y")
        {
            Console.WriteLine("Goodbye!");
            return; // Exit the activity
        }
    }
}