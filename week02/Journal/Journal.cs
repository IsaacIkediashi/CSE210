using System.IO;
using System.Net;
class Journal
{
  public List<Entry> _entries = new List<Entry>();

  public Journal() 
  {    
  }

  public void displayEntries()
  {
    foreach (Entry entry in _entries)
    {
      Console.WriteLine($"Date: {entry._date} - Prompt: {entry._prompt}\n{entry._response}\n");
    }
  }
  public void SaveToFile(string fileName)
  {
    using (StreamWriter outputFile = new StreamWriter(fileName))
    {
      foreach (Entry entry in _entries)
      {
        outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
      }
    }
  }

  public void LoadFromFile(string fileName)
  {
    _entries.Clear();
    string[] lines = System.IO.File.ReadAllLines(fileName);

    foreach (string line in lines)
    {
     string[] parts = line.Split("|");
     Entry entry = new Entry();

     entry._date = parts[0];
     entry._prompt = parts[1];
     entry._response = parts[2];

      _entries.Add(entry);

    }
  }
}