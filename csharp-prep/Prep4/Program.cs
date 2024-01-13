using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Initialize values
        List<int> nums = new List<int>();
        int sum = 0;
        int largest = 0;
        int entry = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (entry != 0)
        {
            Console.Write("Enter number: ");
            entry = int.Parse(Console.ReadLine());
            
            //Add numbers to the list
            if (entry != 0)
            {
                nums.Add(entry);
            }

            //Find the largest number while creating list
            if (entry > largest)
            {
                largest = entry;
            }

            //Sum numbers while creating list
            sum += entry;
        }
        
        float avrg = ((float)sum) / nums.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avrg}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}