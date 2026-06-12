public class Activity
{
  private string _activity;
  private  string _message;
  private int _timeDuration;

  protected Random _randomGenerator;
  public Activity(string name, string text)
  {
    _activity = name;
    _message = text;
    _randomGenerator = new Random();
  }

  public void ShowSpinner(int seconds)
  {
      string[] spinner = {"\\",  "/"};
      
      DateTime startTime = DateTime.Now;
      DateTime endTime = DateTime.Now.AddSeconds(seconds);

      int i = 0;

      while (startTime < endTime)
      {
          Console.Write(spinner[i]);
          Thread.Sleep(200);
          Console.Write("\b \b");

          i++;

          if (i >= spinner.Length)
          {
              i = 0;
          }
          startTime = DateTime.Now;
      }
      Console.Write("\b \b");
  }
  public void StartMessage()
  {
    Console.WriteLine($"Welcome to the {_activity} Activity!");
    Console.WriteLine();
    Console.WriteLine($"{_message}");  
    Console.WriteLine();
    Console.Write("How long should this session last in seconds? ");
    int durationTime = int.Parse(Console.ReadLine());
    SetDuration(durationTime);
    Console.Clear();
    Console.WriteLine("Get Ready...");
    ShowSpinner(6);
    Console.WriteLine();
  }
  public void ShowCountdown(int seconds)
  {
    for (int i = seconds; i > 0; i--)
    {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
    }

        Console.WriteLine();
  }
  public void EndMessage()
  {
    Console.WriteLine("Well done!!");
    ShowSpinner(4);
    Console.WriteLine();
    Console.WriteLine($"You have completed {GetDuration()} seconds of the {_activity} activity.");
    ShowSpinner(60);
  }
  public void SetDuration(int duration)
  {
    _timeDuration = duration;
  }
  public int GetDuration()
  {
    return _timeDuration;
  } 
}