using System;
using System.Collections.Generic;
using System.IO;
class Entry
{
    string date, prompt, response;


    public Entry(string _date, string _prompt, string _response)
    {
        date = _date;
        prompt = _prompt;
        response = _response;
    }
    public void DisplayEntry()
    {
        Console.WriteLine($"{date}: {prompt} - {response} ");
    }
    public string GetEntryAsCSV()
    {
        return $"{date} | {prompt} | {response}";
    }

}