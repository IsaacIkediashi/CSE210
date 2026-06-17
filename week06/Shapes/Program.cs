using System;
using System.Globalization;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {  
      List<Shape> shapes = new List<Shape>();
      shapes.Add(new Square(5.0));
      shapes.Add(new Rectangle(5, 7));
      shapes.Add(new Circle(5.0));
        
      foreach(Shape shape in shapes)
      {
        shape.SetColor("Red");
        Console.WriteLine(shape.GetColor());
        Console.WriteLine(shape.GetArea());
        Console.WriteLine();
      }
    }
}