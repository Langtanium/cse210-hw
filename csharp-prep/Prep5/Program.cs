using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();

        int num = PromptUserNumber();

        int sqrNum = SquareNumber(num);

        DisplayResult(userName, sqrNum);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResult(string userName, int sqrNum)
    {
        Console.WriteLine($"{userName}, the square of your number is {sqrNum}");
    }
}