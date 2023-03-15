using System;
using System.Collections.Generic;
using System.Linq;

public class SimpleGoal : Goal
{
    
    public SimpleGoal(string type) : base(type)
    {
       _goalType = type; 
       Console.Write("What is the name of your goal? ");
       _goalName = Console.ReadLine();
       Console.Write("What is a short description of it? ");
       _description = Console.ReadLine();
       Console.Write("What is the amount of points associated with this goal? ");
       _point = int.Parse(Console.ReadLine());   
       
       _isCompleted = "False";
    }

    public SimpleGoal(string goalType, string goalName, string description, int point, string isCompleted) : base(goalType,goalName, description, point, isCompleted)
    {
        _goalType = goalType;
        _goalName = goalName;
        _description = description;
        _point = point;
        _isCompleted = isCompleted;
    }


}