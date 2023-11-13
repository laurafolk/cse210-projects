using System;
using System.Collections.Generic;

// Listing Activity Class
class ListingActivity : Activity
{
    private List<string> _prompts;
    private string _description;
    private int _responses;
    private int _duration;

    public ListingActivity(string activity, int duration, string description)
        : base(activity, duration)
    {
        _description = description;
        _prompts = new List<string>()
        {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
        };
    }

    public string RandomListeningPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void UserResponses()
    {
        _responses = 0;
        while (_responses < _durationInSeconds)
        {
            string prompt = RandomListeningPrompt();
            Console.WriteLine(prompt);
            Thread.Sleep(1000);
            _responses++;
        }
    }
    public new void RunActivity()
    {
        base.RunActivity();
        Console.WriteLine(_description);
        UserResponses();
    }
}    
        