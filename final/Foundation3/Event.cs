using System;
using System.Collections.Generic;

// Event class
public class Event
{
    protected string _type;
    protected string _eventTitle;
    protected string _description;
    protected string _eventDate;
    protected string _eventTime;    
    protected string _addresses;
    Address _address; 

    // Event Constructor
    public Event(string type, string eventTitle, string description, string eventDate, string eventTime, Address address )
    {
        _type = type;
        _eventTitle = eventTitle;
        _description = description;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _address = address;
    }

    // Print Standard Details marketing messages
    public virtual void StandardDetails()
    {        
        _addresses = _address.GetfieldAddress();
        Console.WriteLine("");
        Console.WriteLine($"Welcome to {_type}!");
        Console.WriteLine($"Title : {_eventTitle}");
        Console.WriteLine($"Description : {_description}");
        Console.WriteLine($"Date : {_eventDate}");
        Console.WriteLine($"Time : {_eventTime}");
        Console.WriteLine($"Address : {_addresses}");       
    }  

    // Print Full Details marketing messages
    public virtual void FullDetails()
    {
         _addresses = _address.GetfieldAddress();
        Console.WriteLine("");
        Console.WriteLine($"Welcome to {_type}!");
        Console.WriteLine($"Title : {_eventTitle}");
        Console.WriteLine($"Description : {_description}");
        Console.WriteLine($"Date : {_eventDate}");
        Console.WriteLine($"Time : {_eventTime}");
        Console.WriteLine($"Address : {_addresses}");  
    }

    // Print Short description marketing messages
    public virtual void ShortDescription()
    {
        Console.WriteLine("");
        Console.WriteLine($"Welcome to {_type}!");
        Console.WriteLine($"Title : {_eventTitle}");        
        Console.WriteLine($"Date : {_eventDate}");       
    }

 
}
