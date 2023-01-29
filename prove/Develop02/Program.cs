using System;
using System.Collections.Generic;

class Program
{   
    static void Main(string[] args)
    {
        int userNum = -1; 
        int index ;
        string userValue = "";   
        string promptQuestion = "";   
        string answer = "";
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();    
        
        Menu menu = new Menu();
        List<Entry> entry = new List<Entry>();
        
        PromptGenerator prompts = new PromptGenerator();
        Random random = new Random(); 

        while ( userNum != 5 )
        {            
            menu.Display(); 
            userValue = menu._userAnswer;
            userNum = int.Parse(userValue);

            if ( userNum == 1 )    
            {                
                Entry writeEntry = new Entry();
                index = random.Next(prompts.prompt.Count);
                promptQuestion = prompts.prompt[index];
                answer = Write(promptQuestion);
                writeEntry._journalDate = dateText;
                writeEntry._ramdomPrompt = promptQuestion;
                writeEntry._journalData = answer;
                entry.Add(writeEntry);          
              
            }
            else if ( userNum == 2)
            {                
                Journal journal = new Journal();
                journal.Display();
            }
            else if ( userNum == 3)
            {
                Journal journal = new Journal();
                journal.SaveToFile();
            }
            else if ( userNum == 4)
            {
                Journal journal = new Journal();
                journal.LoadToFile();
            }
            else
            {
                Console.WriteLine("Finish Journal!");
            }        
        }
    }       

    static string Write(string promptQuestion)
    {
       Console.WriteLine(promptQuestion);
       string answer = Console.ReadLine();
       return answer;
    } 
     
}