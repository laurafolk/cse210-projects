using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        // Create instances of each event type
        Address address1 = new Address("123 Main St", "Cityville", "Stateville", "70345");
        Lecture lectureEvent = new Lecture("Programming Lecture", "Learn about programming", DateTime.Now, new TimeSpan(14, 30, 0), address1, "John Doe", 100);

        Address address2 = new Address("456 Oak St", "Townsville", "Stateville", "67890");
        Reception receptionEvent = new Reception("Networking Reception", "Networking and socializing", DateTime.Now.AddDays(7), new TimeSpan(18, 0, 0), address2, "rsvp@example.com");

        Address address3 = new Address("789 Pine St", "Villageville", "Stateville", "54321");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Summer Picnic", "Enjoy outdoor activities", DateTime.Now.AddDays(14), new TimeSpan(12, 0, 0), address3, "Expect sunny weather");

        // Display marketing messages for each event
        Console.WriteLine("Standard Details:");
        Console.WriteLine("-----------------");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details:");
        Console.WriteLine("--------------");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description:");
        Console.WriteLine("--------------------");
        Console.WriteLine(outdoorEvent.GetShortDescription());
        Console.WriteLine("Full Details for Outdoor Gathering:"); // Added line to show weather statement
        Console.WriteLine("-----------------------------------"); // Added line to show weather statement
        Console.WriteLine(outdoorEvent.GetFullDetails());
    }
}