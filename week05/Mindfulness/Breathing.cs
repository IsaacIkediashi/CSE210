public class Breathing : Activity
{
  public Breathing(string name, string text) : base(name, text)
  {  
  }
  public void Run()
  {
    DateTime beginTime = DateTime.Now;
    DateTime endTime = beginTime.AddSeconds(GetDuration());
    

    Console.Clear();
    StartMessage();


    while (beginTime < endTime) 
    {     
      Console.WriteLine("\nBreathe in...");
      ShowCountdown(4);

      Console.WriteLine("Breathe out...");
      ShowCountdown(4);

      beginTime = DateTime.Now;
    }
    EndMessage();
  }
}
