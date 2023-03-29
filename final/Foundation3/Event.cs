using System;
using System.Collections.Generic;

// Event class
public class Event
{
    private string _type;
    private string _eventTitle;
    private string _description;
    private date _eventDate;
    private date _evnetTime;
    private string _address;
    
    public Event(string type)
    {
        
    }

    public string StandardDetails()
    {
        return _eventTitle;
    }  

    public string FullDetails()
    {
        return _eventTitle;
    }

    public string FullDetails()
    {
        return _description;
    }


}
