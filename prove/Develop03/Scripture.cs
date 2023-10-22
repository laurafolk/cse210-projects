using System;
using System.Collections.Generic;

class Scripture
{
    private Reference Reference { get; }
    private List<Word> Words { get; }

    public Scripture(Reference reference, string text)
    {
        // Constructor: Initializes the scripture with its reference and text.
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
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
            if (word.Hidden)
            {
                Console.Write("________ ");
            }
            else
            {
                Console.Write(word.Text + " ");
            }
        }
        Console.WriteLine();
    }

    public bool IsFullyHidden()
    {
        // Method: Check if all words in the scripture are hidden.
        return Words.All(word => word.Hidden);
    }
}
