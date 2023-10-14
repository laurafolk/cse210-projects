using System;

class PromptGenerator
{
    private List<string> prompts;
    private Random random;

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

        random = new Random();
    }
    public string GetRandomPrompt()  // This is the function also called the method (or behavior).
    {
        int index = random.Next(0, prompts.Count);
        return prompts[index];
    }
}