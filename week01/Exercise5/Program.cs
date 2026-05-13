using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

       
        static string PromptUserName(string user_name)
        {       
                
            return user_name;
        }

       
        static int PromptUserNumber(int user_number)
        {
            return user_number;
        }
        
        static int SquareNumber(int num)
        {
            int square_number = num*num;
            return square_number;
        }
        

        static void DisplayResult (string user_name, int user_number)
        {

            Console.WriteLine($"{user_name}, the square of your number is {SquareNumber(user_number)}");
        }


        DisplayWelcome();

        Console.Write("Please enter your name: "); 
        string user_name = PromptUserName(Console.ReadLine()); 

        Console.Write("Please enter your favorite number: ");
        int user_number = PromptUserNumber(int.Parse(Console.ReadLine()));
        
        DisplayResult(user_name, user_number);
    }
}