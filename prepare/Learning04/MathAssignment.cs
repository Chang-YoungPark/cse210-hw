using System;

public class MathAssginment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssginment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
   
    public void GetHomeworkList()
    {
        string studentName = base.GetSummary();
        Console.WriteLine($"{_textbookSection} {_problems}");
    }
}