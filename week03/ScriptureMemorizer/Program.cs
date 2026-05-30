using System;
using System.Collections.Generic;
using System.IO;


// I exceeded the requirements

 //1. Scriptures are loaded from an external file.
 //2. A random scripture is selected each time the program starts.
 //3. Only words that are not already hidden are selected to be hidden.


class Program
{
    static void Main(string[] args)
    {
        List<string> lines =
            File.ReadAllLines("scriptures.txt").ToList();

        Random random = new Random();

        string selectedLine =
            lines[random.Next(lines.Count)];

        string[] parts = selectedLine.Split('|');

        string book = parts[0];
        int chapter = int.Parse(parts[1]);
        string versePart = parts[2];
        string scriptureText = parts[3];

        Reference reference;

        if (versePart.Contains("-"))
        {
            string[] verses = versePart.Split('-');

            reference = new Reference(
                book,
                chapter,
                int.Parse(verses[0]),
                int.Parse(verses[1])
            );
        }
        else
        {
            reference = new Reference(
                book,
                chapter,
                int.Parse(versePart)
            );
        }

        Scripture scripture =
            new Scripture(reference, scriptureText);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.Write(
                "Press Enter to continue or type 'quit': "
            );

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        Console.WriteLine();
        Console.WriteLine("Program ended.");
    }
}