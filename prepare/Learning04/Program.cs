using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathHomework = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathHomework.GetSummary());
        Console.WriteLine(mathHomework.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment englishHomework = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(englishHomework.GetSummary());
        Console.WriteLine(englishHomework.GetWritingInformation());
    }
}