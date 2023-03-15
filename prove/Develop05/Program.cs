using System;

class Program
{
    static void Main(string[] args)
    {
        string userValue;
        string userGoal;
        string goalType;
        string goalName;
        string description;
        string fileName;
        string strCompleted;
        int point = 0;
        int totalPoint = 0;
        int userNum = -1;
   

        Menu menu = new Menu();  
        List<Goal> goal = new List<Goal>();    

        while ( userNum != 6 )
        {             
            Console.WriteLine($"You have {totalPoint} points.");   
            Console.WriteLine("");        
            // Display menu      
            menu.Display(); 
            userValue = menu._userAnswer;
            userNum = int.Parse(userValue); 

            // 1. Create New Goal
            if ( userNum == 1 )    
            {   
                menu.CreateNewGoal();
                userGoal = menu._userGoal;    
                
                // 1. Simple Goal                  
                if ( userGoal == "1" ) 
                {            
                    goal.Add(new SimpleGoal("SimpleGoal"));                
                }
                // 2. Eternal Goal
                else if ( userGoal == "2")
                {
                    goal.Add(new EternalGoal("EternalGoal"));     
                }
                // 3. Checklist Goal
                else if ( userGoal == "3")
                {
                    goal.Add(new CheckList("CheckList"));     
                }        
            }

            // 2. List Goals
            else if ( userNum == 2)
            {             
                string goalValue = "";
                string[] goalPart;           
                string displayCompleted;
                int num = 0;

                Console.WriteLine("The goals are: ");
                foreach (Goal item in goal)
                {
                    num += 1;
                    goalValue = item.GetDisplayGoal();       
                    goalPart = goalValue.Split("|");
                    goalType = goalPart[0];
                    goalName = goalPart[1];
                    description = goalPart[2];
                    point = int.Parse(goalPart[3]);   
                    strCompleted = goalPart[4];
                    if (strCompleted == "True")
                    {
                        totalPoint += point;
                        displayCompleted = "X";
                    }
                    else
                    {
                        displayCompleted = " ";
                    }
                    if (goalType == "CheckList")
                    {   
                        string bonus = goalPart[5];
                        string times = goalPart[6];   
                        string time = goalPart[7];        

                        if (times == time)
                        {
                            totalPoint += int.Parse(bonus);
                        }

                        Console.WriteLine($"{num}. [{displayCompleted}] {goalName} ({description}) -- Currently completed: {time}/{times} ");
                    }
                    else
                    {
                        Console.WriteLine($"{num}. [{displayCompleted}] {goalName} ({description})");
                    }   
                }   
                
                Console.WriteLine("");
                Console.WriteLine($"You have {totalPoint} points.");   
                Console.WriteLine(""); 
               
            }
            // 3. Save Goals
            else if ( userNum == 3)
            {               
                Console.WriteLine(""); 
                Console.Write("What is the filename for the goal file? ");
                fileName = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {    
                    outputFile.WriteLine(totalPoint);
                    foreach (Goal item in goal)
                    {                   
                        outputFile.WriteLine(item.GetFileGoal());                                     
                    }
                }      
                Console.WriteLine($"Completed!");          
            }
            // 4. Load Goals
            else if ( userNum == 4)
            {               
                Console.Write("What is the filename for the goal file? ");
                fileName = Console.ReadLine();     

                string[] fileLines = System.IO.File.ReadAllLines(fileName);
                totalPoint = int.Parse(fileLines[0]);

                foreach (string line in fileLines)
                {   
                                    
                    string[] parts = line.Split(",");
                    
                    if (parts.Count() > 1 )
                    {   
                        string goalNameLine = parts[0];
                        
                        string[] goalName2 = goalNameLine.Split(":");
                        goalType = goalName2[0];
                        goalName = goalName2[1];
                     
                        description = parts[1];
                        point = int.Parse(parts[2]);
                          
                        if (goalType == "CheckList")
                        {   
                            int bonus = int.Parse(parts[3]);
                            int times = int.Parse(parts[4]);   
                            int time = int.Parse(parts[5]); 

                            if ( times == time )
                            {
                                strCompleted = "True";
                            }
                            else
                            {
                                strCompleted = "False";
                            }
                            goal.Add(new CheckList(goalType, goalName, description, point, strCompleted, bonus, times, time) );
                        
                        }      
                        else if (goalType == "SimpleGoal")
                        {
                            strCompleted = parts[3];
                            goal.Add(new SimpleGoal(goalType, goalName, description, point, strCompleted) );
                        }
                        else if ( goalType == "EternalGoal")
                        {
                            strCompleted = parts[3];
                            goal.Add(new EternalGoal(goalType, goalName, description, point, strCompleted) );
                        }                    

                    } 

                }
                Console.WriteLine($"Completed!");  
            }
            // 5. Record Event 
            else if ( userNum == 5)
            {               
                Console.WriteLine("");     
                string goalValue = "";
                string[] goalPart;     
                List<string> goalNameList = new List<string>();
                
                int num = 0;
    
                foreach (Goal item in goal)
                {
                    num += 1;
                    goalValue = item.GetDisplayGoal();       
                    goalPart = goalValue.Split("|");     
                    goalType = goalPart[0];  
                    goalName = goalPart[1];                   
                    goalNameList.Add(goalName);
                    Console.WriteLine($"{num}. {goalName}");                       
                }        
                Console.Write("Which goal did you accomplish? ");
                string completeNum = Console.ReadLine();
                
                if (int.TryParse(completeNum, out int result))
                {
                    int userRecord = int.Parse(completeNum) - 1;  
                    int userPoint = goal[userRecord].RecordEvent();
                    totalPoint += userPoint;              
                    
                }
                else
                {
                    Console.WriteLine("Input data is invalid, Please input numer.");
                }
                
                Console.WriteLine($"You now have {totalPoint} points.");   
                Console.WriteLine(""); 
            }
            // Quit
            else if ( userNum == 6)
            {                            
                Console.WriteLine("Good Bye");
            }        
        }
    }

}

// menu option 
public class Menu
{
    public string _userAnswer = ""; 
    public string _userGoal = "";  
    public void Display()
    {
        //Console.Clear();
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        _userAnswer = Console.ReadLine();
    }  

    public void CreateNewGoal()
    {        
        Console.WriteLine("The type of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        _userGoal = Console.ReadLine();
    }  
}