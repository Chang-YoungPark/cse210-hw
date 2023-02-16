using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Console.Write("Student Name: ");
        string studentName = Console.ReadLine();
        Console.Write("Topic: ");
        string topic = Console.ReadLine();
        Assignment assignment = new Assignment(studentName, topic);
        studentName = assignment.GetSummary();
        Console.Write("TextBook Section: ");
        string textbookSection = Console.ReadLine();
        Console.Write("Problems: ");
        string problems = Console.ReadLine();
        MathAssginment math = new MathAssginment(studentName, topic, textbookSection, problems);
        math.GetHomeworkList();
        Console.Write("title: ");
        string title = Console.ReadLine();
        WritingAssignment writing = new WritingAssignment(studentName, topic, title);
        writing.GetWritingInformation();
    }
}