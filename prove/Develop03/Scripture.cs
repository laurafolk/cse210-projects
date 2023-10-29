using System;
using System.Collections.Generic;
using System.Linq; //This imports System.Linq namespace for LINQ operations.
using System.IO; //This imports System.IO for file operations.

class Scripture
{
    public Reference Reference { get; }
    public List<Word> Words { get; }

    public Scripture(Reference reference, string text)
    {
        // Constructor: Initializes the scripture with its reference and text.
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideWords()
    {
        foreach (Word word in Words)
        {
            if (!word.Hidden)
            {
                // Replace the word with dashes of the same length
                string dashes = new string('_', word.Text.Length);
                //word.Text = dashes;
                //word.Hide();
            }
        }
    }

    public void RevealWords()
    {
        // Method: Reveal all words in the scripture.
        foreach (Word word in Words)
        {
            word.Reveal();
        }
    }

    public void Display()
    {
        // Method: Display the scripture with hidden words replaced by underscores.
        Console.WriteLine($"{Reference}:\n");

        foreach (Word word in Words)
        {
            // The GetDisplayText method of the word class to display the
            string displayText = word.GetWord();
            Console.Write($"{displayText} ");
        }
        Console.WriteLine();
    }

    public bool IsFullyHidden()
    {
        return Words.All(word => word.Hidden);
    }
}
