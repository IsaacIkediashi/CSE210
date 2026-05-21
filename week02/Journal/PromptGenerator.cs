using System;
using System.Collections.Generic;

class Prompt
{
  public List<string> _prompts = new List<string>();
  public Prompt()
  {    
  }

  public string getRandomInput()
  {
    Random random = new Random();
    int index = random.Next(0, _prompts.Count);
    return _prompts[index];
  }
}