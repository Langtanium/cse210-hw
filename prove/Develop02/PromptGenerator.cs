using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Initializing a list with data
    // https://giannisakritidis.com/blog/Lists-in-csharp/
    public List<string> _prompts = new List<string>()
    {
        "If I had one thing I could do over today, what would it be?",
        "What was the best part of my day?",
        "Who was the most interesting person I interacted with today?",
        "What new things did I learn today?",
        "What things that I'm proud of did I accomplish today?"
    };

    public string GetRandomPrompt()
    {
        Random rndGen = new Random();
        int rndNum = rndGen.Next(0, 4);

        return _prompts[rndNum];
    }
}