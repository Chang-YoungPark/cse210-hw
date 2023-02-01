using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        string strValue;
        double doubleValue;
        Fraction f1 = new Fraction();
        strValue = f1.GetFractionString();
        doubleValue = f1.GetDecimalValue();
        Console.WriteLine(strValue);
        Console.WriteLine(doubleValue);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Fraction f2 = new Fraction(5);
        strValue = f2.GetFractionString();
        doubleValue = f2.GetDecimalValue();
        Console.WriteLine(strValue);
        Console.WriteLine(doubleValue);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Fraction f3 = new Fraction(3, 4);
        strValue = f3.GetFractionString();
        doubleValue = f3.GetDecimalValue();
        Console.WriteLine(strValue);
        Console.WriteLine(doubleValue);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Fraction f4 = new Fraction(1, 3);
        strValue = f4.GetFractionString();
        doubleValue = f4.GetDecimalValue();
        Console.WriteLine(strValue);
        Console.WriteLine(doubleValue);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}