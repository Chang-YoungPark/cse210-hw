using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);
        //Console.Write("What is the magic number? ");
        //string magic = Console.ReadLine();
        //int magicNum = int.Parse(magic);
        int magicNum = number;
        string userValue;
        int userNum;
        do
        {
            Console.Write("What is your guess? ");
            userValue = Console.ReadLine();
            userNum = int.Parse(userValue);
            if (magicNum > userNum)
            {
                Console.WriteLine("Higher");                
            }
            else if (magicNum < userNum)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed it!");
            }

        } while (magicNum != userNum);
            
        
    }


}