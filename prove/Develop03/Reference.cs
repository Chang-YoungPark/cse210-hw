using System;
using System.Collections.Generic;
using System.Linq;

public class Reference
{
    private string _scripture;
    private string _scriptureText;

    // Constructor Reference
    public Reference(string book, int chapter, int startVerse, string scriptureText){
  
        _scripture = $"{book} {chapter}:{startVerse}";
        _scriptureText = scriptureText ;
    }
    // Constructor Reference
    public Reference(string book, int chapter, int startVerse, int endVerse, string scriptureText){
     
        _scripture = $"{book} {chapter}:{startVerse}-{endVerse}";
        _scriptureText = scriptureText;
    }
    
    // getter scripture
    public string GetScripture()
    {
        return _scripture;
    }

    // getter scripture text
    public string GetRenderText()
    {
        return _scriptureText;
    }
}