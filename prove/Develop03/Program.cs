using System;
using System.Collections.Generic;
using System.Linq; //This imports System.Linq namespace for LINQ operations.
using System.IO; //This imports System.IO for file operations.

class Program
{
    static void Main()//(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");
        // Below will Load scriptures from the "scriptures.txt" file and create a progress manager.
        List<Scripture> library = LoadScriptures("Scripture.txt");
        //ProgressManager progressManager = new ProgressManager();

        if (library.Count == 0)
        {
            Console.WriteLine("There are no scriptures found.  Please add scriptures to the file.");
            return;
        }

        ProgressManager progressManager = new ProgressManager();

        Random random = new Random();

        while (true)
        {
            Scripture scripture = library[random.Next(library.Count)]; //Will choose a random scripture from the library.

            Console.Clear();

            //if (!progressManager.IsScriptureFullyMemorized(scripture))
            //{
            scripture.Display();

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break; //Will exit the loop if user types quit.
            }

            scripture.RevealWords(); //Shows words in the scripture.

            //scripture.HideWords(); // Call the HideWords method to hide words.

            if (scripture.IsFullyHidden())
            {
                progressManager.MarkAsCompleted(scripture.Reference);
                Console.WriteLine("You've hidden all the words in he scriptures.  Program ends.");
            }
        }
        //else
        //{
        //    Console.WriteLine("You've already fully memorized this scripture.");
        //}
        //}
        progressManager.SaveProgress("Progress.txt");

        Console.WriteLine("Program ends.");
    }

    static List<Scripture> LoadScriptures(string fileName)
    {
        List<Scripture> library = new List<Scripture>();

        if (File.Exists(fileName))
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|'); //split line by '|' seperating reference and text.
                    if (parts.Length == 2)
                    {
                        Reference reference = new Reference(parts[0]);
                        string text = parts[1];
                        library.Add(new Scripture(reference, text));
                    }
                }
            }
        }

        return library;
    }
}