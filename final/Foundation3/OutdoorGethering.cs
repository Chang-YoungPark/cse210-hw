using System;
using System.Collections.Generic;

// OutdoorGethering class
public class OutdoorGethering : Event
{

    protected string _weatherForecast;
    
    
    public OutdoorGethering(string type, string eventTitle, string description, string eventDate, string eventTime, Address address, string weatherForecast ) : base(type, eventTitle, description,eventDate,eventTime,address)
    {       
        _weatherForecast = weatherForecast;
    }

    // Print Full Details marketing messages
    public override void FullDetails()
    {
        base.FullDetails();
        Console.WriteLine($"Weather forecast : {_weatherForecast} ");        
    } 


}
