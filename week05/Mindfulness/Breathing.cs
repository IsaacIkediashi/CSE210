public class Breathing : Activity
{
  public Breathing(string name, string text) : base(name, text)
  {  
  }
  public void Run()
  {
    Console.Clear();
    StartMessage();
    
    DateTime beginTime = DateTime.Now;
    DateTime endTime = beginTime.AddSeconds(GetDuration());
    
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
