using System;
using System.Collections.Generic;
using System.Linq;

public class ListingActivity : Activity
{
    private List<string> _listQuestion = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List<string> _inputPrompt = new List<string>();

    public ListingActivity(string activityName, string description) : base(activityName, description)
    {
        _activityName = activityName;
        _description = description;        
    }

    public void DisplayListingPrompt()
    {     
        Random rnd = new Random();
        int index = rnd.Next(_listQuestion.Count);
        string selectPrompt = _listQuestion[index];
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {selectPrompt} ---");
        Console.Write("You may begin in: ");           
        int userValue = int.Parse(Console.ReadLine());  
        for(int i = 0 ; i < userValue; i++)
        {
            Console.Write("> ");
            string userText = Console.ReadLine();
            _inputPrompt.Add(userText);
        } 
        Console.WriteLine($"You listed {_inputPrompt.Count} items!");     
    }

}