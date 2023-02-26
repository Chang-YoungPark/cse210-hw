using System;
using System.Collections.Generic;
using System.Linq;


public class FitnessgActivity : Activity
{

    private DateTime _startTime ;
    private DateTime _futureTime ;

    public FitnessgActivity(string activityName, string description) : base(activityName, description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void DisplayFitness()
    {   

        _startTime = DateTime.Now;
        _futureTime = _startTime.AddSeconds(_duration);
        int _seconds = 0; 
        int _remain = 0; 
        Console.Clear();
        Console.WriteLine("Plank Start!");      
        DateTime _currentTime = DateTime.Now;  
        while( _currentTime < _futureTime)
        {        
            Thread.Sleep(1000);
            Console.Write("-");
            _seconds += 1;
            _remain = _seconds%10;
            if ( _seconds > 0 )
            {
                if ( _remain == 0 )
                {
                    Console.WriteLine($"{_seconds} seconds have passed.");
                    Console.WriteLine("");
                }    
            } 
            _currentTime = DateTime.Now;
        }

    }

}