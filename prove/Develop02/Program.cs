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
        
        // Ask username, it will be the name fo journal file 
        while (userName == "")
        { 
            Console.Write("What is your journal name? ");
            userName = Console.ReadLine();        
        }
        newJournal._journalFile = userName + ".txt";

      
        while ( userNum != 5 )
        {        
            // Display menu      
            menu.Display(); 
            userValue = menu._userAnswer;
            userNum = int.Parse(userValue);

            // Write journal
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
            // Display journal
            else if ( userNum == 2)
            {             
                newJournal.Display();
            }
            // Load user journal from the file
            else if ( userNum == 3)
            {               
                newJournal.LoadToFile();
            }
            // Save user journal to the file
            else if ( userNum == 4)
            {
                newJournal.SaveToFile();
            }
            // Quit menu
            else
            {
                Console.WriteLine($"Finish Journal! {newJournal._journalFile}");
            }        
        }
    }       
   
    // get user answer from prompt 
    static string Write(string promptQuestion)
    {
       Console.WriteLine(promptQuestion);
       string answer = Console.ReadLine();
       return answer;
    } 
     
}