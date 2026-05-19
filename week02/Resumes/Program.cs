using System;


class Program
{
    static void Main(string[] args)
    {
        
        Resume myResume = new Resume();
        Job myJob = new Job();

        myResume._name = "Isaac Ikediashi";
        myJob._jobTitle = "Software Engineer";
        myJob._company = "Microsoft";
        myJob._startYear = 2023;
        myJob._endYear = 2026;


        myResume._jobs.Add(myJob);

        // Console.WriteLine($"{myResume._jobs[0]._jobTitle}");

        myResume.DisplayResume();

    }
}

    




