public class Entry
{
    public string _journalDate;
    public string _ramdomPrompt;
    public string _journalData;   

    public void Display()
    {
        Console.WriteLine($"Date: {_journalDate} Prompt: {_ramdomPrompt}");
        Console.WriteLine($"{_journalData}");
    }

}

public class Menu
{
    public string _userAnswer = "";   
    public void Display()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        _userAnswer = Console.ReadLine();
    }  
}

