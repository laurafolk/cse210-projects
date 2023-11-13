using System;
using System.Threading;
using System.Collections.Generic;
// Reflecting Activity Class
public class ReflectingActivity : Activity
{
    private string _description;
    private string[] _prompts;
    private List<string> _reflectionQuestions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string activity, int duration, string description)
        : base(activity, duration)
    {
        _description = description;
        _prompts = new string[] 
        {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        };
    }

    public string RandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }

    public void ShowQuestions()
    {
        foreach (string question in _reflectionQuestions)
        {
            Console.WriteLine(RandomPrompt());
            Thread.Sleep(1000);
            Console.WriteLine(question);
            Thread.Sleep(1000);
        }
    }

    public new void RunActivity()
    {
        base.RunActivity();
        Console.WriteLine(_description);
        ShowQuestions();  
    }
}