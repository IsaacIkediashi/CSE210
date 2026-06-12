public class Listing : Activity
{
  private List<string> _listingPrompts;
  public Listing(string name, string text) : base(name, text)
  {
    _listingPrompts = new List<string>();
  }

 public void Run()
 {

    List<string> _inputs = new List<string>();
    DateTime beginTime = DateTime.Now;
    DateTime endTime = beginTime.AddSeconds(GetDuration());

    Console.Clear();
    StartMessage();

    SetPrompts("Who are people that you appreciate?");
    SetPrompts("What are personal strengths of yours?");
    SetPrompts("Who are people that you have helped this week?");
    SetPrompts("When have you felt the Holy Ghost this month?");
    SetPrompts("Who are some of your personal heroes?");

    int index = _randomGenerator.Next(0, GetPrompt().Count);

    Console.WriteLine("List as many responses as you can to the following prompts:");
    Console.WriteLine($"--- {GetPrompt()[index]}. ---");
    

    Console.WriteLine("You may begin in: ");
    ShowCountdown(6);

    while (beginTime < endTime) 
    {     
      Console.Write("> ");
      string text = Console.ReadLine();
      _inputs.Add(text);
      beginTime = DateTime.Now;
    }
    Console.WriteLine($"You listed {_inputs.Count} items!");
    Console.WriteLine();
    EndMessage(); 
 }
  public void SetPrompts(string prompt)
  {
    _listingPrompts.Add(prompt);
  }

  public List<string> GetPrompt()
  {
    return _listingPrompts;
  }
}