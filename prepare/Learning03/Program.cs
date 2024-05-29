using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

                // User interactive
        // Console.Write("What is the top number? ");
        // string topString = Console.ReadLine();
        // int topInt = int.Parse(topString);

        // Console.Write("What is the bottom number? ");
        // string bottomString = Console.ReadLine();
        // int bottomInt = int.Parse(bottomString);

        // Fraction fraction1 = new Fraction(topInt, bottomInt);
        // Console.WriteLine(fraction1.GetFractionString());
        // Console.WriteLine(fraction1.GetDecimalValue());
        
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}