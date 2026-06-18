using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
      GoalManager manager = new GoalManager();
      while (true)
      {
        // EXCEEDING REQUIREMENTS:
        // Added a player ranking system that awards titles
        // based on total score earned.

        if(manager.GetScore() >= 10000)
        {
        Console.WriteLine("Rank: Eternal Champion");
        }
        else if(manager.GetScore() >= 5000)
        {
        Console.WriteLine("Rank: Saint");
        }
        else if(manager.GetScore() >= 1000)
        {
        Console.WriteLine("Rank: Disciple");
        }

        Console.WriteLine($"You have {manager.GetScore()} points.");
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine(" 1. Create New Goal");
        Console.WriteLine(" 2. List Goals");
        Console.WriteLine(" 3. Save Goals");
        Console.WriteLine(" 4. Load Goals");
        Console.WriteLine(" 5. Record Event");
        Console.WriteLine(" 6. Quit");

        Console.Write("Select a choice from the menu: ");
        int prompt = int.Parse(Console.ReadLine());

        if(prompt == 1)
        {
          Console.WriteLine("The types of goals are:");
          Console.WriteLine(" 1. Simple Goal");
          Console.WriteLine(" 2. Eternal Goal");
          Console.WriteLine(" 3. Checklist Goal");
          
          Console.Write("Which type of goal would you like to create:");
          int goalPick = int.Parse(Console.ReadLine());
          if(goalPick == 1)
          {  
            SimpleGoal simpleGoal = new SimpleGoal();
            simpleGoal.GoalQuery();
            manager.AddGoal(simpleGoal);
          }

          if(goalPick == 2)
          {
           EternalGoal eternalGoal = new EternalGoal();
           eternalGoal.GoalQuery(); 
           manager.AddGoal(eternalGoal);
          }

          if(goalPick == 3)
          {
            Checklist checklist = new Checklist();
            checklist.GoalQuery();
            manager.AddGoal(checklist);
          }
        }

        else if(prompt == 2)
        {
          int i = 1;

          foreach(Goal goal in manager.GetGoals())
          {
              Console.WriteLine($"{i}. {goal.GetDetailsString("")}");
              i++;
          }          
        }

        else if(prompt == 3)
        {
          Console.Write("What is the filename for the goal file? ");
          string fileName = Console.ReadLine();

          using (StreamWriter outputFile = new StreamWriter(fileName))
          {
            outputFile.WriteLine(manager.GetScore());
            foreach(Goal goal in manager.GetGoals())
            {
                outputFile.WriteLine(goal.GetStringRepresentation(0));
            }
          }
        }

        else if(prompt == 4)
        {
          Console.Write("What is the file name for the goal file? ");
          string fileName = Console.ReadLine();
          string[] lines = System.IO.File.ReadAllLines(fileName);
          manager.SetScore(int.Parse(lines[0]));
          for(int i = 1; i < lines.Length; i++)
          {
            string line = lines[i];
            string[] parts = line.Split('|');

            if(parts[0] == "SimpleGoal")
            {
                // recreate SimpleGoal
            }
            else if(parts[0] == "EternalGoal")
            {
                // recreate EternalGoal
            }
            else if(parts[0] == "ChecklistGoal")
            {
                // recreate ChecklistGoal
            }
          }
        }

        else if(prompt == 5)
        {
          if(manager.GetGoals().Count == 0)
          {
              Console.WriteLine("No goals available.");
              continue;
          }
          Console.WriteLine("The goals are:");

          for(int i = 0; i < manager.GetGoals().Count; i++)
          {
              Console.WriteLine($"{i + 1}. {manager.GetGoals()[i].GetShortName()}");
          }

          Console.Write("Which goal did you accomplish? ");
          int choice = int.Parse(Console.ReadLine()) - 1;

          Goal selectedGoal = manager.GetGoals()[choice];

          selectedGoal.RecordEvent();

          manager.AddScore(selectedGoal.GetPoints());

          if(selectedGoal is Checklist checklist)
          {
              if(checklist.IsComplete())
              {
                  manager.AddScore(checklist.GetBonus());
              }
          }

          Console.WriteLine($"Congratulations! You earned {selectedGoal.GetPoints()} points!");
        }

        else if(prompt == 6)
        {
            Console.WriteLine("Goodbye!");
            break;
        }
        else
        {
            Console.WriteLine("Invalid option.");
        }
      }
    }
}