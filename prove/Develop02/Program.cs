using System;
//using System.Collections.Generic;
class Program //A "class" is just a template and becomes useful when an instance is create and assigned to a variable in the program.
{
    static void Main(string[] args) //This is the beginning of the program.
    {
        Journal journal = new Journal(); //This instance of Journal is created and assigned the variable of journal.
        int menuUserinput = 0;
        //menu and user input variables
        List<string> menu = new List<string>
            {
                "Please select what you would like to do from the list below: ",
                "1.  Write a new entry",
                "2.  Display the journal entry",
                "3.  Save the journal entry to a file.",
                "4.  Load the journal entry from a file.",
                "5.  Quit",
                "What would you like to do? "
            };
        while (menuUserinput != 5) //The program will continue to run until 5 is entered to quit.
        {
            foreach(string menueItem in menu)
            {
                //string date = DateTime.Now.ToString("MM/dd/yyyy");
                Console.WriteLine(menueItem);
            }
            menuUserinput = int.Parse(Console.ReadLine());

            if (menuUserinput == 1)
            {
                journal.WriteJournalEntries();
            }
            else if (menuUserinput == 2)
            {
                journal.DisplayJournalEntries();
            }
            else if (menuUserinput == 3)
            {
                Console.WriteLine("Enter the filename to save the journal to: ");
                string fileName = Console.ReadLine();
                journal.SaveToCSV(fileName);
                Console.WriteLine($"Journal successfully saved to {fileName}.");
            }
            else if (menuUserinput == 4)
            {
                Console.WriteLine("Enter the filename to load the journal from: ");
                string fileName = Console.ReadLine();
                journal.LoadFromCSV(fileName);
                Console.WriteLine($"Journal successfully loaded from {fileName}. ");
            }
        }
        if (menuUserinput == 5)
        {
            Console.WriteLine("Goodbye, until your next Journal Entry. ");
        }
    }
}