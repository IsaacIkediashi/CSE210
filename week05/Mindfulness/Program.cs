using System;

class Program
{
    static void Main(string[] args)
    {      
       while (true)
        {
          Random randomGenerator = new Random();
          Breathing breathing = new Breathing("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
          Listing listing = new Listing("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
          Reflection reflection = new Reflection("Reflection","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

          Console.Clear();
          Console.WriteLine("Welcome - This is the mindfulness app");
          Console.WriteLine();
          Console.WriteLine("Menu Options:");
          Console.WriteLine(" 1. Start Breathing activity");
          Console.WriteLine(" 2. Start Listing activity");
          Console.WriteLine(" 3. Reflection activity");
          Console.WriteLine(" 4. Quit");

          Console.Write("Please select an option: ");
          int userOption = int.Parse(Console.ReadLine());

          if(userOption == 1)
          {  
            breathing.Run();
          }
          
          if(userOption == 2)
          {
            listing.Run();            
          }

          if(userOption == 3)
          {           
            reflection.Run();
          }

          if(userOption == 4)
          {
            break; 
          }

        }
      
    }
}