// Added code to make sure that the questions in the reflect activity are not asked more than once.

using System;

class Program
{
    static void Main(string[] args)
    {
        int selection = 0;

        while (selection != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            selection = int.Parse(Console.ReadLine());

            Console.Clear();

            if (selection == 1)
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.DisplayStartingMessage();
                breathing.Run();
            }
            else if (selection == 2)
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.DisplayStartingMessage();
                reflection.Run();
            }
            else if (selection == 3)
            {
                ListingActivity listing = new ListingActivity();
                listing.DisplayStartingMessage();
                listing.Run();
            }
        }
    }
}