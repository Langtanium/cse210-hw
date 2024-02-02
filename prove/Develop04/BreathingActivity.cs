using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through beathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountDown(3);
            Console.WriteLine();
            Console.Write("Now breathe out... ");
            ShowCountDown(3);
            Console.WriteLine();
        }

        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(5);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }
}