using System;
using System.Collections.Generic;
using System.Threading;

// Main Program Class
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Mindfulness Program");

        while (true)
        {
            Console.WriteLine("Select an activity: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write(" > ");

            //int choice = int.Parse(Console.ReadLine());

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input.  Please enter a number. ");
                continue;
            }

            if (choice == 4)
            {
                Console.WriteLine("Till next time!");
                break;
            }

            int duration = 0;
            Console.WriteLine("Enter the duration for this activity (in seconds): ");
            if (!int.TryParse(Console.ReadLine(), out duration))
            {
                Console.WriteLine("Invalid input. Please enter a number in seconds for the duration. ");
                continue;
            }

            switch (choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", duration, "This activity will help you relax by focusing on your breathing.");
                    breathingActivity.RunActivity();
                    //break;  keeping in case needed again.

                    int breatheInDuration = 5;
                    int holdDuration = 5;
                    int breatheOutDuration = 7;

                    breathingActivity.BreatheInBreatheOutAnimation(breatheInDuration, holdDuration, breatheOutDuration);
                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", duration, "Reflect on your experiences.");
                    reflectingActivity.RunActivity();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity("Listing Activity", duration, "List positive things in your life.");
                    listingActivity.RunActivity();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
