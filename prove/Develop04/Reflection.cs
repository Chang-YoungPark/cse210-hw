using System;
using System.Collections.Generic;
using System.Linq;

public class ReflectionActivity : Activity
{
    private List<string> _prompt = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };
    private List<string> _questions = new List<string>()
    { 
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };
    
    private DateTime _startTime ;
    private DateTime _futureTime ;

    public ReflectionActivity(string activityName, string description) : base(activityName, description)
    {
        _activityName = activityName;
        _description = description;        
    }
    
    public void DisplayReflectionPrompt()
    {
        _startTime = DateTime.Now;
        _futureTime = _startTime.AddSeconds(_duration);
        Random rnd = new Random();
        int index = rnd.Next(_prompt.Count);
        string selectPrompt = _prompt[index];
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine(selectPrompt);
        Console.WriteLine("");
        Console.Write("When you have something in mind, press enter to continue.");             
        Console.ReadLine();    
    }

    public void DisplayQuestion()
    {
        Random rnd = new Random();
        DateTime _currentTime = DateTime.Now;
      
       
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        int userValue = int.Parse(Console.ReadLine());             
        Console.Clear();
        while( _currentTime < _futureTime)
        {
            int index = rnd.Next(_questions.Count);
            string selectQuestion = _questions[index];
            Console.Write(selectQuestion);
            DisplayPause(userValue); 
            Console.WriteLine("");
            _currentTime = DateTime.Now;
        }

    }

}