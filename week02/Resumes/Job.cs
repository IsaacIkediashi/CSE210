using System;

// Job job1 = new Job();
// job1._jobTitle = "Software Engineer";
// job1._company = "Microsoft";
// job1._startYear = 2023;
// job1._endYear = 2026;
// job1.DisplayJobDetails();

// Job job2 = new Job();
// job2._jobTitle = "Software Engineer";
// job2._company = "Apple";
// job2._startYear = 2023;
// job2._endYear = 2026;
// job2.DisplayJobDetails();

// Console.WriteLine("job1._company");
// Console.WriteLine("job2._company");
    
    


public class Job
{  
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    public Job()
    {           
    }  
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company})  {_startYear}-{_endYear}");
    }
}
