using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction oneFraction = new Fraction();
        Fraction fiveFraction = new Fraction(5);
        Fraction threeFourthFraction = new Fraction(3,4);
        Fraction oneThirdFraction = new Fraction(1,3);

        Console.WriteLine($"{oneFraction.GetFractionString()}");
        Console.WriteLine($"{oneFraction.GetDecimalValue()}");

        Console.WriteLine($"{fiveFraction.GetFractionString()}");
        Console.WriteLine($"{fiveFraction.GetDecimalValue()}");

        Console.WriteLine($"{threeFourthFraction.GetFractionString()}");
        Console.WriteLine($"{threeFourthFraction.GetDecimalValue()}");

        Console.WriteLine($"{oneThirdFraction.GetFractionString()}");
        Console.WriteLine($"{oneThirdFraction.GetDecimalValue()}");
    }
}