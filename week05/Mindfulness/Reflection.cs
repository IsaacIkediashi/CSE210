public class Reflection : Activity
{
  private List<string> _reflectionPrompts;
  private List<string> _reflectionQuestions;
  public Reflection(string name, string text) : base(name, text)
  {
    _reflectionPrompts = new List<string>();
    _reflectionQuestions = new List<string>();
  }
  
  public void SetQuestions(string questions)
  {
  _reflectionQuestions.Add(questions);
  }
  public void SetPrompts(string prompt)
  {
  _reflectionPrompts.Add(prompt);
  }
  public List<string> GetPrompt()
  {
    return _reflectionPrompts;
  }
  public List<string> GetQuestion()
  {
    return _reflectionQuestions;
  }

  public void Run()
  {
    Console.Clear();

    StartMessage();
    
    SetPrompts("Think of a time when you stood up for someone else.");
    SetPrompts("Think of a time when you did something really difficult.");
    SetPrompts("Think of a time when you helped someone in need.");
    SetPrompts("Think of a time when you did something truly selfless.");
    
    int prompt = _randomGenerator.Next(0, GetPrompt().Count);
    int question = _randomGenerator.Next(0, GetQuestion().Count);
    

    Console.WriteLine("Consider the following prompt:");
    Console.WriteLine();
    Console.WriteLine($"--- {GetPrompt()[prompt]}. ---");
    Console.WriteLine();
    Console.WriteLine("The moment something comes to mind, press Enter to proceed.");
    Console.Write("");
    Console.WriteLine();
    

    SetQuestions("Why was this experience meaningful to you?");
    SetQuestions("Have you ever done anything like this before?");
    SetQuestions("How did you get started?");
    SetQuestions("How did you feel when it was complete?");
    SetQuestions("What made this time different than other times when you were not as successful?");
    SetQuestions("What is your favorite thing about this experience?");
    SetQuestions("What could you learn from this experience that applies to other situations?");
    SetQuestions("What did you learn about yourself through this experience?");
    SetQuestions("How can you keep this experience in mind in the future?");
    

    Console.WriteLine("Ponder on each of these following questions as they relate to your experience");
    Console.WriteLine("\nYou may begin in:");
    Console.WriteLine();
    ShowCountdown(5);
    Console.Clear();
    
    DisplayQuestion(question, 8);
    DisplayQuestion(question, 8);

    EndMessage();
  }
  public void DisplayQuestion(int index, int seconds)
  {
    Console.Write($"> {GetQuestion()[index]}");
    ShowSpinner(seconds);
    Console.WriteLine();

// I added this so as not to pick the same question, anytime we call this function.
    GetQuestion().RemoveAt(index);
  }
}