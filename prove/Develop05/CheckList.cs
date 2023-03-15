using System;
using System.Collections.Generic;
using System.Linq;

public class CheckList : Goal
{
    
    public CheckList(string type) : base(type)
    {
       _goalType = type; 
       Console.Write("What is the name of your goal? ");
       _goalName = Console.ReadLine();
       Console.Write("What is a short description of it? ");
       _description = Console.ReadLine();
       Console.Write("What is the amount of points associated with this goal? ");
       _point = int.Parse(Console.ReadLine());   
       Console.Write("How many times does this goal need to be accomplished for a bonus? ");
       _bonus = int.Parse(Console.ReadLine());  
       Console.Write("What is the bonus for accomplishing it that many times? ");
       _times = int.Parse(Console.ReadLine());  
       
       _isCompleted = "False";
    }

    public CheckList(string goalType, string goalName, string description, int point, string isCompleted, int bonus, int times, int time ) : base(goalType,goalName, description, point, isCompleted)
    {
        _goalType = goalType;
        _goalName = goalName;
        _description = description;
        _point = point;
        _isCompleted = isCompleted;
        _bonus = bonus;
        _times = times;
        _time = time;
    }

    public override string GetDisplayGoal()
    {   
        _goalValue = $"{_goalType}|{_goalName}|{_description}|{_point}|{_isCompleted}|{_bonus}|{_times}|{_time}";     
        return _goalValue;
    }

    public override string GetFileGoal()
    {   
        string fileGoal = $"{_goalType}:{_goalName},{_description},{_point},{_bonus},{_times},{_time}";     
        return fileGoal;
    }

    public override int RecordEvent()
    {
        _time += 1;
        Console.WriteLine($"Congratulations, You earned {_point}");
        return _point;
    }
    
}