using System;

class Program
{
    static void Main(string[] args)
    {
        // Address  
        Address address = new Address( "123 Main St", "Saltlake", "UT", "USA", "12345" );
        // Event
        Event e1 = new Event("Event", "Event", "description", "2023-04-02", "14:59", address );
        e1.StandardDetails();
        e1.FullDetails();
        e1.ShortDescription();

        // Lectures
        Lecture e2 = new Lecture("Lecture", "Math", "Trigonomerical function", "2023-04-02", "14:59", address, "Howard Hunter", 20 );
        e2.StandardDetails();
        e2.FullDetails();
        e2.ShortDescription();

        // Reception
        Reception e3 = new Reception("Reception", "Wedding Reception", "Temple Wedding", "2023-04-02", "14:59", address, "wedding@weddingmail.com" );
        e3.StandardDetails();
        e3.FullDetails();
        e3.ShortDescription();

        // OutdoorGathering
        OutdoorGethering e4 = new OutdoorGethering("Outdoor gathering", "Marathon", "Utah Marathon Festival", "2023-04-02", "14:59", address, "The temperature ranged from a low of 49F(9.4C) to a high of 73F(22.8C)" );
        e4.StandardDetails();
        e4.FullDetails();
        e4.ShortDescription();
    }
}