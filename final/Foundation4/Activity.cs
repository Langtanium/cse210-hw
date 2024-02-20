using System;

public abstract class Activity
{
    private int _time;

    public Activity(int time)
    {
        _time = time;
    }

    public virtual string GetSummary(string activityType)
    {
        DateTime currentTime = DateTime.Now;
        return currentTime + " " + activityType + " (" + _time.ToString() + "): Distance: " + GetDistance().ToString() + " km, Speed: " + GetSpeed().ToString() + " kph, Pace: " + GetPace().ToString() + " min per km";
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public int GetTime()
    {
        return _time;
    }
}