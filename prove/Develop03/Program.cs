// Program uses a list of scriptures and randomly selects one each time the the user runs the program.
using System;

class Program
{
    static void Main(string[] args)
    {
        string quit = "";
        Random randGen = new Random();
        int randomScripture = randGen.Next(0, 2);

        List<Reference> references = new List<Reference>()
        {
            new Reference("Proverbs", 3, 5, 6),
            new Reference("Philippians", 4, 13),
            new Reference("3 Nephi", 5, 13)
        };
        List<string> scriptureTexts = new List<string>()
        {
            "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknoledge him, and he shall direct thy paths.",
            "I can do all things through Christ which strengtheneth me",
            "Behold, I am a disciple of Jesus Christ, the Son of God. I have been called of him to declare his word among his people, that they might have everlasting life."
        };

        Scripture myScripture = new Scripture(references[randomScripture], scriptureTexts[randomScripture]);

        while (quit.ToLower() != "quit" && myScripture.IsCompletelyHidden() == false)
        {
            Console.Clear();

            Console.WriteLine(myScripture.GetDisplayText());
            Console.WriteLine();

            Console.WriteLine("Press enter to contine or type 'quit' to finish:");
            quit = Console.ReadLine();

            if (quit.ToLower() != "quit")
            {
                myScripture.HideRandomWords(3);
            }
        }

        if (quit.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(myScripture.GetDisplayText());
        }
    }
}