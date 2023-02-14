using System;
using System.Collections.Generic;
using System.Linq;

public class Word
{
  private string _hidden;
  private string _show;

  // Constructor Word  
  public Word(string scripture, string scriptureText)
  {
    _show = scripture;
    _hidden = scriptureText;
  }

  public void Hide(string hidden)
  {
    _hidden = hidden;           
  } 
   
  // Show Word  
  public void GetRenderText()
  {
        Console.Clear();
        Console.WriteLine($"{_show}:  {_hidden}");        
  }
   
}