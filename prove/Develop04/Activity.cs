using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "Activity";
        _description = "Activity description";
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine("Welcome to the " + _name + ".");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long in seconds would you like your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animText = new List<string>()
        {
            "|",
            "/",
            "-",
            "\\"
        };

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < futureTime)
        {
            string anim = animText[i];
            Console.Write(anim);
            Thread.Sleep(500);
            Console.Write("\b \b");
            
            i++;

            if (i >= animText.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}