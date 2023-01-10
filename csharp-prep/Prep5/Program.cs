using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string userName = GetUserName();
        int userNum = GetUserNumber();
        int squareNum = GetSquareNumber(userNum);
        DisplayResult(userName, squareNum);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string GetUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int GetUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userVal = Console.ReadLine();
        int userNum = int.Parse(userVal);
        return userNum;
    }
  
    static int GetSquareNumber(int userNum)
    {
        userNum = userNum * userNum;
        return userNum;
    }   

    static void DisplayResult(string userName, int squareNum)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNum}");
    }

}