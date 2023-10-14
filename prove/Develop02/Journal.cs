using System;
using System.IO;
class Journal
{
    List<Entry> entries; // Will hold the Journal entries made by the user.
    PromptGenerator promptGenerator;
    public Journal()
    {
        entries = new List<Entry>();
        promptGenerator = new PromptGenerator();
    }

    public void WriteJournalEntries()
    {
        string date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        //Console.WriteLine("Enter the date (e.g. October 03, 2023): ");
        //string date = Console.ReadLine();

        Console.WriteLine("Choose a prompt: ");
        //PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);

        Console.WriteLine("Enter your response: ");
        string response = Console.ReadLine();

        Entry entry = new Entry(date, prompt, response);
        entries.Add(entry);

        Console.WriteLine("Entry added successfully. ");
    }
    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }
    public void SaveToCSV(string fileName)
    {
        List<string> records = new List<string>();
        foreach (Entry entry in entries)
        {
            records.Add(entry.GetEntryAsCSV());
        }
        File.WriteAllLines(fileName, records);
        Console.WriteLine($"Journal succeffsully saved to {fileName}.");
        //Console.WriteLine("Name of the file you wnat to save? ");
    }
    public void LoadFromCSV(string fileName)
    {
        Console.WriteLine("Name of file to load?");
        string _fileName = Console.ReadLine();
        entries.Clear(); //Add this line to clear existing entries before loading from the file.

        List<string> records = File.ReadAllLines(fileName).ToList();
        foreach (string record in records)
        {
            string[] splitString = record.Split('|');
            Entry entry = new Entry(splitString[0], splitString[1], splitString[2]);
            entries.Add(entry);
        }
    }
}