using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Isaac Ikediashi", "Inheritance");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Isaac Ikediashi", "Algebra", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Isaac Ikediashi", "European History", "The Causes of World War II by Isaac Ikediashi");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}