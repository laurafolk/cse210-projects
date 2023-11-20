class SimpleGoal : Activity
{
    public bool IsComplete { get; set; }

    public SimpleGoal(string name, int value) : base(name, value)
    {
        IsComplete = false;
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"{Name} [{(IsComplete ? "X" : " ")}] - {Value} points");
    }
}

// using System;
// class SimpleGoal : Activity
// {
//     public bool IsComplete { get; set; }

//     public SimpleGoal(string name, int value) : base(name, value)
//     {
//         IsComplete = false;
//     }

//     public override void DisplayStatus()
//     {
//         Console.WriteLine($"{Name} [{(IsComplete ? "X" : " ")}] - {Value} points");
//     }
// }
