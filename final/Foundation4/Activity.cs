using System;
using System.Collections.Generic;

// Activity class
public class Activity
{
    protected string _type;
    protected double _distance;
    protected double _speed;
    protected double _pace;  
    protected string _activityDate;
    protected double _minutes;
    
    // Constructor Activity
    public Activity(string type, string activityDate, double minutes)
    {
        _type = type;
        _activityDate = activityDate;
        _minutes = minutes;
    }

    // calculate distance
    public virtual double CalDistance()
    {       
        return _distance;
    }  

    // calculate speed
    public virtual double CalSpeed()
    {        
        return _speed;
    }

    // calculate pace
    public virtual double CalPace()
    {         
        return _pace;
    }
    // print summary
    public void GetSummary()
    {
        Console.WriteLine("");        
        Console.WriteLine($"{_activityDate} {_type} ({_minutes} min)-Distance {CalDistance()} miles, Speed {CalSpeed()},");
        Console.WriteLine($"Pace: {CalPace()} min per mile"); 
    } 
}
