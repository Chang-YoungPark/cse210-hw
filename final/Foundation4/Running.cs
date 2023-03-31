using System;
using System.Collections.Generic;

// Running class
public class Running : Activity
{
    // Constructor
    public Running(string type, string activityDate, double minutes, double distance) : base(type, activityDate, minutes)
    {
        _distance = distance;
    }

    // calculate speed
    public override double CalSpeed()
    {
        _speed = (_distance / _minutes) * 60;
        return _speed;
    }

    // calculate pace
    public override double CalPace()
    {
        _pace = _minutes / _distance;
        return _pace;
    }

}
