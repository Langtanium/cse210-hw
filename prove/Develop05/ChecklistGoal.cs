using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name,description,points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted += 1;
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        if (_amountCompleted >= _target)
        {
            return "[X]" + _shortName + " (" + _description + ") -- Currently Completed: " + _amountCompleted + "/" + _target;
        }
        else
        {
            return "[ ]" + _shortName + " (" + _description + ") -- Currently Completed: " + _amountCompleted + "/" + _target;
        }
    }

    public override string GetStringReprensentation()
    {
        return "ChecklistGoal:" + _shortName + "," + _description + "," + _points + "," + _bonus + "," + _target + "," + _amountCompleted;
    }
}