using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private string _scripture;
    private string _scriptureVerse;
 
    // Constructor Scripture 
    public Scripture(string book, int chapter, int startVerse, string scriptureText)
    {     
        Reference reference = new Reference(book, chapter, startVerse, scriptureText);
        _scripture = reference.GetRenderText();
        _scriptureVerse = reference.GetScripture();
    }           

    // Constructor Scripture 
    public Scripture(string book, int chapter, int startVerse, int endVerse, string scriptureText)
    {     
        Reference reference = new Reference(book, chapter, startVerse, endVerse, scriptureText);
        _scripture = reference.GetRenderText();
        _scriptureVerse = reference.GetScripture();
    } 

    // Hide word 
    public void HideWords()
    {         
        string[] words = _scripture.Split(' ');
        string[] wordSave = words;
        string replaceValue = "";
        string showValue = "";
        Random rnd = new Random();
        Word wordClass = new Word(_scriptureVerse, _scripture);

        while( words.Length > 0)
        {
            int index = rnd.Next(words.Length);
            string removeWord = words[index];
            words = words.Where((val, idx) => idx != index).ToArray();
                
            for ( int i = 0; i < wordSave.Length; i++)
            {
                if (wordSave[i] == removeWord)
                {
                    for(int j = 0; j < wordSave[i].Length; j++ )
                    {
                        replaceValue += "_";
                    }
                    wordSave[i] = replaceValue;
                    replaceValue = "";
                }    
            }              
            showValue = string.Join(" ", wordSave);
            wordClass.Hide(showValue);
            wordClass.GetRenderText();           
            Console.WriteLine("Press Enter to hide more words or type 'Quit' to exit.");

            string input = Console.ReadLine();
            if (input == "Quit")
            {
            break;
            }        

        } 
    }          
    // Show Scripture         
    public string GetRenderText()
    {
        Console.Clear();
        Console.WriteLine($"{_scriptureVerse}: {_scripture}");
        return _scripture;
    }

}