using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
      Console.Write("What is your grade percentage? ");
      string user_input = Console.ReadLine();
      
      int grade = int.Parse(user_input);
      string letter = "";
      string grade_sign = "";
      int remainder = grade % 10;

      if (grade >= 90)
        {
           letter = "A"; 
        }
      else if (grade >= 80)
        {
           letter = "B";   
        }
      else if (grade >= 70)
        {
           letter = "C";  
        }
      else if (grade >= 60)
        {
           letter = "D"; 
        }       
      else 
        {
           letter = "F"; 
        }
      if (remainder >= 7)
        {
           grade_sign = "+";
        }
      else
        {
           grade_sign = "-"; 
        }

      if (letter =="A" || letter == "F")  {
           Console.WriteLine($"Your grade is {letter}");   
        }
      else
        {
            Console.WriteLine($"Your grade is {letter}{grade_sign}");
        }
      

      if (grade == 70 || grade > 70)
        {
           Console.WriteLine("Congratulations! you passed the course");
        }
      else
        {
           Console.WriteLine("Sorry, you did not meet the requirements to pass the course");
        }
    }
}