using System;
using System.Collections.Generic;
using System.Linq; //This imports System.Linq namespace for LINQ operations.
using System.IO;
class ProgressManager
{
    // Attribute: A dictionary to store user progress for each scripture.
    private Dictionary<Scripture, bool> Progress { get; } = new Dictionary<Scripture, bool>();

    // Constructor: Initializes the ProgressManager.
    public ProgressManager()
    {
        // The constructor initializes the Progress dictionary when a ProgressManager instance is created.
    }

    // Method: Check if the user has fully memorized a scripture.
    public bool IsScriptureFullyMemorized(Scripture scripture)
    {
        // Check if the scripture is fully memorized by looking it up in the Progress dictionary.
        if (Progress.TryGetValue(scripture, out bool isMemorized))
        {
            return isMemorized;
        }
        return false;
    }

    // Method: Mark a scripture as fully memorized.
    public void MarkScriptureAsMemorized(Scripture scripture)
    {
        // Mark the scripture as fully memorized by adding it to the Progress dictionary.
        if (!Progress.ContainsKey(scripture))
        {
            Progress[scripture] = true;
        }
    }
}
