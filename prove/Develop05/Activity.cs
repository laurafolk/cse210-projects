using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Base class for all activities
abstract class Activity
{
    public string Name { get; set; }
    public int Value { get; set; }

    public Activity(string name, int value)
    {
        Name = name;
        Value = value;
    }

    public abstract void DisplayStatus();
}

//Below is code before changes at 4:35 on 11-19-23
// using System;
// abstract class Activity
// {
//     public string Name { get; set; }
//     public int Value { get; set; }

//     public Activity(string name, int value)
//     {
//         Name = name;
//         Value = value;
//     }

//     public abstract void DisplayStatus();
// }
