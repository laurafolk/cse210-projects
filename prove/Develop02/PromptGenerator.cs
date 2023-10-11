using System;
using System.Collections.Generic;
using System.IO;
class PromptGenerator
{
    List<string> prompts;

    public PromptGenerator()  //The responsibility is to hold and display question prompts.
    {
        prompts = new List<string>
        {
            "What am I grateful for today? ",
            "How have I seen the Lords hand in my life today? ",
            "What was the best part of my day today? ",
            "Did anything interesting happen today? ",
            "How did you help someone today? ",
            "What was a chalenge that I faced today and how did I overcome it? ",
        };
    }
    public string GetRandomPrompt()  // This is the function also called the method (or behavior).
    {
        Random random = new Random();
        int index = random.Next(0, 6);
        return prompts[index];
    }
}