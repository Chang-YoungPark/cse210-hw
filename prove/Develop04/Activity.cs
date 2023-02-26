using System;
using System.Collections.Generic;
using System.Linq;

public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public void DisplayStart()
    {         
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.");  
        Console.WriteLine("");
        Console.WriteLine(_description);  
    }

    public void SetDuration()
    {
        Console.WriteLine(""); 
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    
    public void DisplayGetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplayPause(2);
       
    }

    public void DisplayPause(int val)
    {
        for(int i=1; i < val; i++)
        {
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("─");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
             Console.Write("─");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
        }
    }

    public void DiplayEnd()
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        DisplayPause(2);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} Activity.");
        DisplayPause(2);
    }
}

// menu option 
public class Menu
{
    public string _userAnswer = "";   
    public void Display()
    {
        Console.Clear();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Start Fitness activity");
        Console.WriteLine("5. Quit");
        Console.Write("Select a choice from the menu: ");
        _userAnswer = Console.ReadLine();
    }  
}