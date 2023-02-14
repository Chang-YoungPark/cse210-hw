using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
    
        string userValue;    
        string sentence;
        string book;
        int chapter;
        int startVerse;
        int endVerse;
        string scriptureText;

        // User Select Menu
        Console.WriteLine("Welcome! Scripture Memorizer");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Proverbs 3:5");
        Console.WriteLine("2. Proverbs 3:5-6");
        Console.WriteLine("3. Quit");
        userValue = Console.ReadLine();
        // Select 1
        if (userValue=="1")
        {
            book = "Proverbs";
            chapter = 3;
            startVerse = 5;
            scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding";
            Scripture scripture = new Scripture(book, chapter, startVerse, scriptureText);
            sentence = scripture.GetRenderText();            
            scripture.HideWords();
        }
        // Select 2
        else if (userValue == "2")
        {
            book = "Proverbs";
            chapter = 3;
            startVerse = 5;
            endVerse = 6;
            scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding" +
                            "In all thy ways acknowledge him, and he shall direct thy paths.";
                     
            Scripture scripture = new Scripture(book, chapter, startVerse, endVerse, scriptureText);
            sentence = scripture.GetRenderText();
            scripture.HideWords();       
            
        }
        // Select 3
        else if (userValue == "3")
        {
            Console.WriteLine("Goodbye~ Scripture Memorizer");
        }            
        
    }
}