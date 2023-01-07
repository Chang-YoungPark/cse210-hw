using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("Your Grade percentage? ");
        string user_grade = Console.ReadLine();
        int num_grade = int.Parse(user_grade);        
        int num_grade2 = 0;
        string letter ="";
        string letter_grade ="";

        if (num_grade >= 90)
        {
            letter = "A";
            num_grade2 = num_grade - 90;
            if (num_grade2 >=7 ) 
            {
               letter_grade = "+";     
            }
            else if (num_grade2 < 3 )
            {
                letter_grade = "-";
            }
            
        }
        else if (num_grade >= 80)
        {
            letter = "B";
            num_grade2 = num_grade - 80;
            if (num_grade2 >=7 ) 
            {
               letter_grade = "+";     
            }
            else if (num_grade2 < 3 )
            {
                letter_grade = "-";
            }
        }
        else if (num_grade >= 70)
        {
            letter = "C";
            num_grade2 = num_grade - 70;
            if (num_grade2 >=7 ) 
            {
               letter_grade = "+";     
            }
            else if (num_grade2 < 3 )
            {
                letter_grade = "-";
            }
        }
        else if (num_grade >= 60)
        {
            letter = "D";
            num_grade2 = num_grade - 60;
            if (num_grade2 >=7 ) 
            {
               letter_grade = "+";     
            }
            else if (num_grade2 < 3 )
            {
                letter_grade = "-";
            }            
        }
        else if (num_grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your Grade is {letter}{letter_grade}: {user_grade}"); 
    }
}