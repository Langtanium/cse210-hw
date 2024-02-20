using System;

public class CyclingActivity : Activity
{
    public double _speed;

    public CyclingActivity(int time, double speed) : base(time)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed / 60 * ((double)GetTime());
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}