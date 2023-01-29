using System;
using System.Collections.Generic;

class Program
{   
    static void Main(string[] args)
    {
        int userNum = -1; 
        int index ;
        string answer = "";
        string userValue = "";   
        string promptQuestion = "";   
        string userName = "";

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();    
        
        Menu menu = new Menu();       
        PromptGenerator prompts = new PromptGenerator();
        Random random = new Random(); 
        Journal newJournal = new Journal();

        while (userName == "")
        { 
            Console.Write("What is your journal name? ");
            userName = Console.ReadLine();        
        }
        newJournal._journalFile = userName + ".txt";

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
                newJournal._entries.Add(writeEntry);        
            }
            else if ( userNum == 2)
            {             
                newJournal.Display();
            }
            else if ( userNum == 3)
            {               
                newJournal.LoadToFile();
            }
            else if ( userNum == 4)
            {
                newJournal.SaveToFile();
            }
            else
            {
                Console.WriteLine($"Finish Journal! {newJournal._journalFile}");
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