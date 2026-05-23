using System.IO;
using System.Net;
class Journal
{
  public List<Entry> _entries = new List<Entry>();

  public Journal() 
  {    
  }

  public void AddEntry(Entry anEntry)
  {
    _entries.Add(anEntry);
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
      outputFile.WriteLine($"Date,Prompt,Response");
      foreach (Entry entry in _entries)
      {
        outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
      }
    }
  }

  public void LoadFromFile(string fileName)
  {
    _entries.Clear();
    string[] lines = System.IO.File.ReadAllLines(fileName);

    for(int i = 1; i < lines.Length; i++)
    {
      string line = lines[i];

      string[] parts = ParseCsvLine(line);

      Entry entry = new Entry();

      entry._date = parts[0];
      entry._prompt = parts[1];
      entry._response = parts[2];

      _entries.Add(entry);
    }
  }

  private string[] ParseCsvLine(string line)
{
    List<string> fields = new List<string>();
    bool inQuotes = false;
    string currentField = "";

    foreach (char c in line)
    {
        if (c == '"')
        {
            inQuotes = !inQuotes;
        }
        else if (c == ',' && !inQuotes)
        {
            fields.Add(currentField);
            currentField = "";
        }
        else
        {
            currentField += c;
        }
    }

    fields.Add(currentField);

    return fields.ToArray();
}
}