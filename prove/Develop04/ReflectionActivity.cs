using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private List<bool> _questionAsked = new List<bool>()
    {
        false, false, false, false, false, false, false, false, false
    };

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of you life.";
    }

    public void Run()
    {
        string prompt = GetRandomPrompt();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        //Console.WriteLine($" --- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            DisplayQuestion();
            ShowSpinner(10);
            Console.WriteLine();
        }

        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(5);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public string GetRandomPrompt()
    {
        Random rndGen = new Random();
        int rnd = rndGen.Next(0, 3);
        return _prompts[rnd];
    }

    public string GetRandomQuestion()
    {
        Random rndGen = new Random();
        int rnd = -1;
        bool continueLoop = true;
        while (continueLoop)
        {
            rnd = rndGen.Next(0, 8);
            if (_questionAsked[rnd] == false)
            {
                _questionAsked[rnd] = true;
                continueLoop = false;
            }
            else if (_questionAsked.All(q=> q == true))
            {
                continueLoop = false;
            }
        }

        if (_questionAsked.All(q=> q == true))
        {
            return "No more questions available.";
        }
        else
        {
            return _questions[rnd];
        }
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($" --- {prompt} ---");
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.Write($"> {question} ");
    }
}