using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);
        
        Console.Write("What is the magic number? ");
        int random_number = int.Parse(Console.ReadLine());

        // Console.Write("What is the magic number? ");
        // int user_guess = int.Parse(Console.ReadLine());
        
        int i = 0;
        while (true)
        {
            i += 1;   
            if (random_number > magic_number)
            {
                Console.WriteLine("Lower!");  
                Console.Write("What is your guess? ");
                random_number = int.Parse(Console.ReadLine());              
            }
            else if (random_number < magic_number)
            {
                Console.WriteLine("Higher!");   
                Console.Write("What is your guess? ");
                random_number = int.Parse(Console.ReadLine());            
            }
            else
            {
                Console.WriteLine($"You guessed it in {i} attempts!");
                Console.Write("Do you want to play again (yes/no)? ");
                string user_answer = Console.ReadLine();
                if (user_answer == "yes")
                {
                   magic_number = randomGenerator.Next(1, 100);
                   Console.Write("What is your guess? ");
                   random_number = int.Parse(Console.ReadLine()); 
                   i = 0;
                }
                else
                {
                    break;
                }
            }
        }
    }
}