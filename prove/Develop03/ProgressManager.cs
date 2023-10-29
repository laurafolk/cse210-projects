using System;
using System.Collections.Generic;
using System.IO;

class ProgressManager
{
    private List<Reference> completedReferences = new List<Reference>();

    public void MarkAsCompleted(Reference reference)
    {
        if (!completedReferences.Contains(reference))
        {
            completedReferences.Add(reference);
        }
    }

    public void SaveProgress(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Reference reference in completedReferences)
            {
                writer.WriteLine(reference.ToString());
            }
        }
    }
}
