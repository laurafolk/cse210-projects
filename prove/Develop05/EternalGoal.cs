using System;
class EternalGoal : Activity
{
    public EternalGoal(string name, int value) : base(name, value) { }

    public override void DisplayStatus()
    {
        Console.WriteLine($"{Name} - {Value} points");
    }
}

// using System;
// class EternalGoal : Activity
// {
//     public EternalGoal(string name, int value) : base(name, value) { }

//     public override void DisplayStatus()
//     {
//         Console.WriteLine($"{Name} - {Value} points");
//     }
// }
