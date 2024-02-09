using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int selection = 0;

        while (selection != 6)
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            selection = int.Parse(Console.ReadLine());

            if (selection == 1)
            {
                CreateGoal();
            }
            else if (selection == 2)
            {
                ListGoalDetails();
            }
            else if (selection == 3)
            {
                SaveGoals();
            }
            else if (selection == 4)
            {
                LoadGoals();
            }
            else if (selection == 5)
            {
                RecordEvent();
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine();
    }

    public void ListGoalNames()
    {
        foreach (Goal singleGoal in _goals)
        {
            string goalDetails = singleGoal.GetDetailsString();
            string[] parts1 = goalDetails.Split(":");
            string[] parts2 = parts1[1].Split(",");
            Console.WriteLine(parts2[0]);
        }
    }

    public void ListGoalDetails()
    {
        foreach (Goal singleGoal in _goals)
        {
            Console.WriteLine(singleGoal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int goalType = int.Parse(Console.ReadLine());

        if (goalType == 1)
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is the short description of it? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int goalPoints = int.Parse(Console.ReadLine());

            SimpleGoal simple = new SimpleGoal(goalName, goalDescription, goalPoints);

            _goals.Add(simple);
        }
        else if (goalType == 2)
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is the short description of it? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int goalPoints = int.Parse(Console.ReadLine());

            EternalGoal eternal = new EternalGoal(goalName, goalDescription, goalPoints);

            _goals.Add(eternal);
        }
        else if (goalType == 3)
        {
            Console.Write("What is the name of your goal? ");
            string goalName = Console.ReadLine();
            Console.Write("What is the short description of it? ");
            string goalDescription = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            int goalPoints = int.Parse(Console.ReadLine());
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int goalTarget = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int goalBonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklist = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);

            _goals.Add(checklist);
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The Goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal singleGoal = _goals[i];
            string goalDetails = singleGoal.GetStringReprensentation();
            string[] parts1 = goalDetails.Split(":");
            string[] parts2 = parts1[1].Split(",");
            int order = i + 1;

            Console.WriteLine($"{order}. {parts2[0]}");
        }

        Console.Write("Which goal did you accomplish? ");
        int goalSelect = int.Parse(Console.ReadLine());

        Goal goalRecorded = _goals[goalSelect-1];

        if (!goalRecorded.IsComplete())
        {
            int score = goalRecorded.RecordEvent();
            _score += score;

            Console.WriteLine($"Congradulations! You have just earned {score} points!");
            Console.WriteLine($"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("You have already completed that goal.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal singleGoal in _goals)
            {
                outputFile.WriteLine(singleGoal.GetStringReprensentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        int linesLength = lines.Count();

        _score = int.Parse(lines[0]);

        for (int i = 1; i < linesLength; i++)
        {
            string line = lines[i];
            string[] parts1 = line.Split(":");
            string[] parts2 = parts1[1].Split(",");

            string name = parts2[0];
            string description = parts2[1];
            int points = int.Parse(parts2[2]);

            if (parts1[0] == "SimpleGoal")
            {
                SimpleGoal simple = new SimpleGoal(name, description, points);
                if (parts2[3] == "True")
                {
                    simple.RecordEvent();
                }
                _goals.Add(simple);
            }
            else if (parts1[0] == "EternalGoal")
            {
                EternalGoal eternal = new EternalGoal(name, description, points);
                _goals.Add(eternal);
            }
            else if (parts1[0] == "ChecklistGoal")
            {
                int bonus = int.Parse(parts2[3]);
                int target = int.Parse(parts2[4]);
                int amountCompleted = int.Parse(parts2[5]);

                ChecklistGoal checklist = new ChecklistGoal(name, description, points, target, bonus);

                for (int j = 0; j < amountCompleted; j++)
                {
                    checklist.RecordEvent();
                }

                _goals.Add(checklist);
            }
        }
    }
}