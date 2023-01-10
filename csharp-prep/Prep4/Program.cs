using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        int userNum = -1;       
        string userValue;
        Console.WriteLine("Enter a list of number, type 0 when finished.");
        while ( userNum != 0 )
        {
            Console.Write("Enter number: ");
            userValue = Console.ReadLine();
            userNum = int.Parse(userValue);
            if (userNum != 0)
            {
                numbers.Add(userNum);         
            }
        }

        int sumNum = numbers.Sum();
        float avrNum = (float)sumNum / numbers.Count();
        int maxNum = numbers.Max();
        int minNum = numbers.Min();
               

        Console.WriteLine($"The sum is:{sumNum}");
        Console.WriteLine($"The average is: {avrNum}");
        Console.WriteLine($"The largest number is: {maxNum}"); 
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        for (int i=0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]); 
        } 
    }
}