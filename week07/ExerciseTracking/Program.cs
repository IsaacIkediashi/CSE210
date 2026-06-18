using System;

class Program
{
    static void Main(string[] args)
    {
      List<Activity> activities = new List<Activity>();
      activities.Add(new Running(4.8, 30));
      activities.Add(new Cycling(64.0, 30));
      activities.Add(new Swimming(20, 30));

      foreach(Activity activity in activities)
      {
        Console.WriteLine(activity.GetSummary());
      }
    }
}