using System;

class Program
{
    static void Main(string[] args)
    {
        // Initialize selection variable and main Journal
        int selection = 0;
        Journal myJournal = new Journal();
    
        // Loop until selection equals 5
        while (selection != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            selection = int.Parse(Console.ReadLine());

            // Code for collecting and storing entries
            if (selection == 1)
            {
                DateTime currentTime = DateTime.Now;
                string dateText = currentTime.ToShortDateString();
                PromptGenerator randomPrompt = new PromptGenerator();
                Entry newEntry = new Entry();

                newEntry._date = dateText;
                newEntry._promptText = randomPrompt.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);

                Console.Write("> ");
                newEntry._entryText = Console.ReadLine();

                myJournal.AddEntry(newEntry);
            }
            // Code for displaying all entries
            else if (selection == 2)
            {
                myJournal.DisplayAll();
            }
            // Code for loading a csv file
            else if (selection == 3)
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();

                Console.WriteLine("Do you want to overwrite existing data? ");
                string overwrite = Console.ReadLine();
                string overLower = overwrite.ToLower();

                if (overLower == "yes")
                {
                    myJournal.ClearJournal();
                }

                myJournal.LoadFromFile(fileName);
            }
            // Code for saving a csv file
            else if (selection == 4)
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();

                myJournal.SaveToFile(fileName);
            }
        }
    }
}