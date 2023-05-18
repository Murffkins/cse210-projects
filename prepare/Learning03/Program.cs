using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning03 World!");

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        // f1.SetTop(2);
        // f1.SetBottom(2);
        // Console.WriteLine(f1.GetTop());
        // Console.WriteLine(f1.GetBottom());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        // Console.WriteLine(f2.GetTop());
        // Console.WriteLine(f2.GetBottom());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        // Console.WriteLine(f3.GetTop());
        // Console.WriteLine(f3.GetBottom());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}
