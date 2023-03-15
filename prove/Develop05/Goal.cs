using System;
using System.Collections.Generic;
using System.Linq;

public class Goal
{
    //Declare variables
    protected string _goalType; 
    protected string _goalName; 
    protected string _description;
    protected string _fileName;
    protected string _goalValue;
    protected string _isCompleted;
    protected int _point;
    protected int _totalPoint = 0;
    protected int _bonus;
    protected int _times;
    protected int _time;

    //Constructor : Making Goal 
    public Goal(string goalType)
    {
           
    }
    
    //Constructor : Getting Values of Goal
    public Goal(string goalType, string goalName, string description, int point, string isCompleted)
    {         
        _goalType = goalType;
        _goalName = goalName;
        _description = description;
        _point = point;
        _isCompleted = isCompleted;
    }

    public virtual string GetDisplayGoal()
    {   
        _goalValue = $"{_goalType}|{_goalName}|{_description}|{_point}|{_isCompleted}";     
        return _goalValue;
    }

    public virtual string GetFileGoal()
    {   
        string fileGoal = $"{_goalType}:{_goalName},{_description},{_point},{_isCompleted}";     
        return fileGoal;
    }

    public virtual int RecordEvent()
    {
        _isCompleted = "True";
        Console.WriteLine($"Congratulations, You earned {_point}");
        return _point;
    }

    public virtual int GetPoint()
    {
        return _totalPoint;
    }

}

