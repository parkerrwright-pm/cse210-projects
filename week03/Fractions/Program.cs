using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction first = new Fraction();
        Fraction second = new Fraction(5);
        Fraction third = new Fraction(3, 4);
        Fraction fourth = new Fraction(1, 3);

        Console.WriteLine(first.GetFractionString());
        Console.WriteLine(first.GetDecimalValue());

        Console.WriteLine(second.GetFractionString());
        Console.WriteLine(second.GetDecimalValue());

        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());

        Console.WriteLine(fourth.GetFractionString());
        Console.WriteLine(fourth.GetDecimalValue());

        third.SetTop(6);
        third.SetBottom(7);
        Console.WriteLine($"New top: {third.GetTop()}");
        Console.WriteLine($"New bottom: {third.GetBottom()}");
    }
}
