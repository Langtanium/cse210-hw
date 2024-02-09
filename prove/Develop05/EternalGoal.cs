using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {}

    public override void RecordEvent()
    {
        int none = 0;
        if (none == 0)
        {
            none++;
        }
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringReprensentation()
    {
        return "EternalGoal:" + _shortName + "," + _description + "," + _points;
    }
}