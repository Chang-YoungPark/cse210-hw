using System;

class Program
{
    static void Main(string[] args)
    {

        string title;
        string author;
        string userValue;
        string userComment;
        int userNum = 0;
        int length; 
        
        Menu menu = new Menu();                   
        List<Video> videos = new List<Video>();    
      
        while ( userNum != 3 )
        {        
            // Display menu      
            menu.Display(); 
            userValue = menu._userAnswer;
            userNum = int.Parse(userValue);

            // Add video and Comments
            if ( userNum == 1 )    
            {   
                userComment = "";
                Console.Write("What is the title of the video? ");
                title = Console.ReadLine();  
                Console.Write("Who is the author of the video? ");
                author = Console.ReadLine();  
                Console.Write("What is the lenth of the video? ");
                length = int.Parse(Console.ReadLine());  

                Video video = new Video(title, author, length); 
                              

                while(userComment.ToUpper() != "NO")
                {
                    Console.WriteLine("");
                    Console.Write("Do you want to add Comments?(Yes or No) ");
                    userComment = Console.ReadLine();
                    if (userComment.ToUpper() == "YES")
                    {   
                        Console.Write("Your Name?: ");
                        string namePerson = Console.ReadLine();
                        Console.Write("Please input your comment: ");
                        string textComment = Console.ReadLine();    
                        video.AddComment(namePerson, textComment);
                    } 
                }
                videos.Add(video);

            }            
            // Display Video
            else if ( userNum == 2)
            {            
                foreach(Video video2 in videos)
                {                 
                    video2.Display();
                }    
            }       
           
            // Quit menu
            else
            {
                Console.WriteLine($"Finish YouTube!");
            }        
        }


    }
}

// menu option 
public class Menu
{
    public string _userAnswer = "";   
    public void Display()
    {
        Console.WriteLine("");
        Console.WriteLine("Welcome to YouTube Videos!");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine("1. Add Video");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Quit");
        Console.Write("What would you like to do? ");
        _userAnswer = Console.ReadLine();
    }  
}
