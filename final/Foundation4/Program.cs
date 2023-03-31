using System;

class Program
{
    static void Main(string[] args)
    {
        // Make List for Polymorphism
        List<Activity> _activity = new List<Activity>();

        // Running 30 minutes 3 miles
        Running runActivity = new Running("Running", "29 March 2023", 30, 3);
        _activity.Add(runActivity);

        // Cycling 60 minutes 5 mph
        Cycling cycleActivity = new Cycling("Cycling", "30 March 2023", 60, 5);
        _activity.Add(cycleActivity);

        // Swimming 45 minutes 30 laps
        Swimming swimActivity = new Swimming("Swimming", "31 March 2023", 45, 30);
        _activity.Add(swimActivity);

        Console.WriteLine("Polymorphism with Exercise Tracking!");
        // print Activity List
        foreach (Activity item in _activity)
        {
            item.GetSummary();                        
        }

    }
}