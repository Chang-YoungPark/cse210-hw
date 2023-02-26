using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string userValue;
        int userNum = -1;
        string activityName;
        string description;
        Menu menu = new Menu();      
     


        while ( userNum != 5 )
        {        
            // Display menu      
            menu.Display(); 
            userValue = menu._userAnswer;
            userNum = int.Parse(userValue);           

            // Start Breathing Activity
            if ( userNum == 1 )    
            {       
                activityName = "BreathingActivity";
                description = "This activity will help you relax by walking your through breathing in and out slowly. \nClear your mind and focus on your breathing.";   
                Console.WriteLine(activityName);      
                BreathingActivity breathing = new BreathingActivity(activityName, description);
                breathing.DisplayStart();     
                breathing.SetDuration();
                breathing.DisplayGetReady();
                breathing.DisplayBreathing();
                breathing.DiplayEnd();                
            }
            // Start reflection Activity
            else if ( userNum == 2)
            {             
                activityName = "ReflectionActivity";
                description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
                description += "This will help you recognize the power you have and how you can use it in other aspects of your life";   
                Console.WriteLine(activityName);      
                ReflectionActivity reflection = new ReflectionActivity(activityName, description);
                reflection.DisplayStart();     
                reflection.SetDuration();
                reflection.DisplayGetReady();
                reflection.DisplayReflectionPrompt();
                reflection.DisplayQuestion();
                reflection.DiplayEnd();     
            }
            // Start Listing Activity
            else if ( userNum == 3)
            {               
                activityName = "ListingActivity";
                description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
                
                Console.WriteLine(activityName);      
                ListingActivity reflection = new ListingActivity(activityName, description);
                reflection.DisplayStart();     
                reflection.SetDuration();
                reflection.DisplayGetReady();
                reflection.DisplayListingPrompt();
                reflection.DiplayEnd();     
             
            }
            // Start Fitness Activity
            else if ( userNum == 4)
            {               
                activityName = "FitnessActivity";
                description = "This activity will help you strengthen your body by workout as Plank.";
                
                Console.WriteLine(activityName);      
                FitnessgActivity Fitness = new FitnessgActivity(activityName, description);
                Fitness.DisplayStart();     
                Fitness.SetDuration();
                Fitness.DisplayGetReady();
                Fitness.DisplayFitness();
                Fitness.DiplayEnd();                  
            }
            // Quit
            else if ( userNum == 5)
            {                            
                Console.WriteLine("Good Bye");
            }        
        }

    }


}