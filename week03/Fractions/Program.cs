using System;

class Program
{
    static void Main(string[] args)
    {
      Fraction fraction = new Fraction();
      Fraction fraction1 = new Fraction(6);
      Fraction fraction2 = new Fraction(6, 7);
      
      fraction.SetTop(3);
      fraction.SetBottom(4);

      Console.WriteLine(fraction.GetTop());
      Console.WriteLine(fraction.GetBottom());

      Console.WriteLine(fraction.GetFractionString());
      Console.WriteLine(fraction.GetDecimalValue());


      Console.WriteLine(fraction1.GetFractionString());
      Console.WriteLine(fraction1.GetDecimalValue());

      Console.WriteLine(fraction2.GetFractionString());
      Console.WriteLine(fraction2.GetDecimalValue());
    }
}