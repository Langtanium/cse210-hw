using System;

public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(int time, int laps) : base(time)
    {
        _laps = laps;
    }

    public override string GetSummary(string activityType)
    {
        DateTime currentTime = DateTime.Now;
        return currentTime + " " + activityType + " (" + GetTime().ToString() + "): Distance: " + GetDistance().ToString() + " km, Speed: " + GetSpeed().ToString() + " kph, Pace: " + GetPace().ToString() + " min per km, Laps: " + _laps.ToString();
    }

    public override double GetDistance()
    {
        return ((double)_laps) * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return (((double)_laps) * 50 / 1000) / ((double)GetTime()) * 60;
    }

    public override double GetPace()
    {
        return ((double)GetTime()) / (((double)_laps) * 50 / 1000);
    }
}