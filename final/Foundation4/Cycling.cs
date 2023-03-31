using System;
using System.Collections.Generic;

// Cycling class
public class Cycling : Activity
{ 
    // Constructor
    public Cycling(string type, string activityDate, double minutes, double speed) : base(type, activityDate, minutes)
    {
        _speed = speed;
    }

    // calculate distance
    public override double CalDistance()
    {
        _distance = _speed * _minutes;
        return _distance;
    }  

    // calculate pace
    public override double CalPace()
    {
        _pace = 60 / _speed;
        return _pace;
    }

}
