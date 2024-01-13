using System;

class Program
{
    static void Main(string[] args)
    {
        Random randGen = new Random();
        int num = randGen.Next(1,100);

        int guess = 0;

        while (guess != num)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > num)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < num)
            {
                Console.WriteLine("Higher");
            }
        }
        Console.WriteLine("You guess it!");
    }
}