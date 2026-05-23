using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        DateTime currentTime = DateTime.Now;
               
        Prompt prompt = new Prompt();
        Entry entry = new Entry();
        Journal journal = new Journal();

        Console.WriteLine("Welcome to the Journal Program!");

        prompt._prompts.Add("Who was the most interesting person I interacted with today?");
        prompt._prompts.Add("What was the best part of my day?");
        prompt._prompts.Add("How did I see the hand of the Lord in my life today?");
        prompt._prompts.Add("What was the strongest emotion I felt today?");
        prompt._prompts.Add("If I had one thing I could do over today, what would it be?");
        prompt._prompts.Add("How did you invite the savior into your activities today?");
        prompt._prompts.Add("What made me smile today?");

        while (true)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");

            Console.Write("What would you like to do? ");
            int userChoice = int.Parse(Console.ReadLine());
                      

            if (userChoice == 1)
            {
                string selected_prompt = prompt.getRandomInput();
                Console.WriteLine(selected_prompt);

                Console.Write("> ");
                string userResponse = Console.ReadLine();
                
                string currentDate = currentTime.ToShortDateString();

                entry._date = currentDate;
                entry._prompt = selected_prompt;
                entry._response = userResponse;

                journal.AddEntry(entry);
            }
            else if (userChoice == 2)
            {
                journal.displayEntries();
            }
            else if (userChoice == 3)
            {
                Console.Write("What is the file name? ");
                string loadFileName = Console.ReadLine();
                journal.LoadFromFile(loadFileName);   
            }
            else if (userChoice == 4)
            {
                Console.Write("What is the file name? ");
                string saveFileName = Console.ReadLine();
                journal.SaveToFile(saveFileName);  
                
            }
            else
            {
             break;
            }  
        }
        
    }
}