using System;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName)
    {
        _studentName = studentName;
    }

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        Console.WriteLine($"{_studentName} - {_topic}") ;   
        return _studentName;   
    }

}
