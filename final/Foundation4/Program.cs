using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity running = new RunningActivity(30, 4.8);
        Console.WriteLine(running.GetSummary("Running"));

        Console.WriteLine();

        CyclingActivity cycling = new CyclingActivity(20, 6);
        Console.WriteLine(cycling.GetSummary("Cycling"));

        Console.WriteLine();

        SwimmingActivity swimming = new SwimmingActivity(25, 5);
        Console.WriteLine(swimming.GetSummary("Swimming"));
    }
}