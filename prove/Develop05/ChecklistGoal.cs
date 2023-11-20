using System;
class ChecklistGoal : Activity
{
    public int TargetCount { get; set; }
    public int CompletedCount { get; set; }

    public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
    {
        TargetCount = targetCount;
        CompletedCount = 0;
    }

    public override void DisplayStatus()
    {
        Console.WriteLine($"{Name} - Completed {CompletedCount}/{TargetCount} times - {Value} points each, {GetBonus()} bonus");
    }

    private int GetBonus()
    {
        if (CompletedCount == TargetCount)
        {
            return 500; // Example bonus value
        }
        return 0;
    }
}

// using System;
// class ChecklistGoal : Activity
// {
//     public int TargetCount { get; set; }
//     public int CompletedCount { get; set; }

//     public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
//     {
//         TargetCount = targetCount;
//         CompletedCount = 0;
//     }

//     public override void DisplayStatus()
//     {
//         Console.WriteLine($"{Name} - Completed {CompletedCount}/{TargetCount} times - {Value} points each, {GetBonus()} bonus");
//     }

//     private int GetBonus()
//     {
//         if (CompletedCount == TargetCount)
//         {
//             return 500; // Example bonus value
//         }
//         return 0;
//     }
// }
