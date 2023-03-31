using System;
using System.Collections.Generic;

// Reception class
public class Reception : Event
{
    
    protected string _peopleRSVP;   
    
    public Reception(string type, string eventTitle, string description, string eventDate, string eventTime, Address address, string peopleRSVP) : base(type, eventTitle, description,eventDate,eventTime,address)
    {
        _peopleRSVP = peopleRSVP;
    }

    
    // Print Full Details marketing messages
    public override void FullDetails()
    {
        base.FullDetails();
        Console.WriteLine($"Email for RSVP : {_peopleRSVP} ");
    }    

}
