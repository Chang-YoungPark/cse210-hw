using System;
using System.Collections.Generic;

// Lecture class
public class Lecture : Event
{
    protected string _speaker;
    protected int _limitCapacity;
    
    public Lecture(string type, string eventTitle, string description, string eventDate, string eventTime, Address address, string speaker, int limitCapacity ) : base(type, eventTitle, description,eventDate,eventTime,address)
    {
        _speaker = speaker;
        _limitCapacity = limitCapacity;
    }

    // Print Full Details marketing messages
    public override void FullDetails()
    {
        base.FullDetails();
        Console.WriteLine($"Speaker : {_speaker} ");
        Console.WriteLine($"Capacity : {_limitCapacity}");
    } 

}
