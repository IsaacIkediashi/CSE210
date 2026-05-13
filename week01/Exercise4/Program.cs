using System.Collections.Generic;
using System.Globalization;


class Program
{
    static void Main(string[] args)
    {
      List<int> numbers = new List<int>();
      Console.WriteLine("Enter a List of numbers, type 0 when finished.");
      int total = 0;
      int max_number = 0;
      int min_number = 1000;
      
      while (true)
      {
        Console.Write("Enter number: ");
        string user_num = Console.ReadLine();
        int num = int.Parse(user_num);
        if (num != 0)
        {
          numbers.Add(num);
        }        
        else
        {       
          foreach (int number in numbers)
          {
            total += number;
            if (number > max_number)
            {
              max_number = number;
            }
            if (number < min_number)
            {
              if (number > 0)
              {
                min_number = number;
              }
              else
              {
                continue;
              }             
            }
          }
          float average = total/numbers.Count();
          Console.WriteLine($"The sum is: {total}");
          Console.WriteLine($"The average is: {average}");
          Console.WriteLine($"The largest number is: {max_number}");
          Console.WriteLine($"The smallest positive number is: {min_number}");

          numbers.Sort();

          Console.WriteLine("The sorted list is:");
          foreach (int numeric_unit in numbers)
          {
            Console.WriteLine($"{numeric_unit}");
          }         
          break;
        }
      }
          
    }
}