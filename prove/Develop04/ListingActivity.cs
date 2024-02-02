using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        Console.WriteLine();
        Console.WriteLine("List as many responses to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> userList = new List<string>();
        userList = GetListFromUser();
        _count = userList.Count;
        Console.WriteLine($"You listed {_count} items!");

        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(5);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public void GetRandomPrompt()
    {
        Random rndGen = new Random();
        int rnd = rndGen.Next(0, 4);
        Console.WriteLine($" --- {_prompts[rnd]} ---");
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            userList.Add(Console.ReadLine());
        }

        return userList;
    }
}