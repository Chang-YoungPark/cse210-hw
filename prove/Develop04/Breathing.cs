using System;
using System.Collections.Generic;
using System.Linq;

public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description) : base(activityName, description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void DisplayBreathing()
    {
        for(int i=0; i < (this._duration/10);i++)
        {        
            Console.WriteLine("");  
            Console.Write("Breathe in...");         
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("");
            Console.Write("Now Breathe out...");
            Console.Write("6");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("5");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("4");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");          
            Console.WriteLine("");
        }    
    }

}