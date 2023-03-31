using System;
using System.Collections.Generic;

// Swimming class
public class Swimming : Activity
{
    // Swimming: number of laps
    protected double _swimmingLaps;  
    // Constructor
    public Swimming(string type, string activityDate, double minutes, double swimmingLaps) : base(type, activityDate, minutes)
    {
        _swimmingLaps = swimmingLaps;
    }

    // calculate distance
    public override double CalDistance()
    {
        _distance = _swimmingLaps * 50 / 1000 * 0.62;
        return Math.Round(_distance,2);
    }  

    // calculate speed
    public override double CalSpeed()
    {
        _speed = ( CalDistance() / _minutes ) * 60;
        return Math.Round(_speed,2);
    }

    // calculate pace
    public override double CalPace()
    {
        _pace = _minutes / CalDistance();
        return Math.Round(_pace,2);
    }

}
