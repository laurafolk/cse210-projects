using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? "); //(core requirement 1)
        string answer = Console.ReadLine();  //(core requirement 1)
        int percent = int.Parse(answer);  //(core requirement 1)

        string letter = "";

        if (percent >= 90)  //(core requirement 1 & 3)
        {
// (core requirement 1)  Console.WriteLine("Your letter grade is an A. ");
            letter = "A";
        }
        else if (percent >= 80)  //(core requirement 1 & 3)
        {
// (core requirement 1)   Console.WriteLine("Your grade is an B. ");
            letter = "B";
        }
        else if (percent >= 70)  //(core requirement 1 & 3)
        {
// (core requirment 1)    Console.WriteLine("Your grade is an C. ");
            letter = "C";
        }
        else if (percent >= 60)  //(core requirement 1 & 3)
        {
// (core requirement 1)     Console.WriteLine("Your grade is an D. ");
            letter = "D";
        }
        else
        {
            letter = "F";
        }

            Console.WriteLine($"Your grade is: {letter} ");

        if (percent >= 70) //(Step 2 core requirement)
        {
            Console.WriteLine("Congratulatons!  You have a passing grade way to go. "); //(Step 2 core requirement)
        }
        else //(Step 2 core requirement)
        {
            Console.WriteLine("You did not pass.  That's ok try harder you will do better next time. ");  //(Step 2 core requirement)
        }
    }
}