using System.IO;
using System;
using System.Collections.Generic;

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

    // =========================
    // SAVE (Excel-safe CSV)
    // =========================
    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine("Date,Prompt,Response");

            foreach (Entry entry in _entries)
            {
                string date = EscapeCsv(entry._date);
                string prompt = EscapeCsv(entry._prompt);
                string response = EscapeCsv(entry._response);

                outputFile.WriteLine($"\"{date}\",\"{prompt}\",\"{response}\"");
            }
        }
    }

    // =========================
    // LOAD
    // =========================
    public void LoadFromFile(string fileName)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(fileName);

        for (int i = 1; i < lines.Length; i++)
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

    // =========================
    // ESCAPE CSV VALUES
    // =========================
    private string EscapeCsv(string text)
    {
        if (text.Contains("\""))
        {
            text = text.Replace("\"", "\"\"");
        }

        return text;
    }

    // =========================
    // CSV PARSER (quote-safe)
    // =========================
    private string[] ParseCsvLine(string line)
    {
        List<string> fields = new List<string>();
        bool inQuotes = false;
        string currentField = "";

        for (int i = 0; i < line.Length; i++)
        {
            char c = line[i];

            if (c == '"')
            {
                // Handle escaped quotes ("")
                if (inQuotes && i + 1 < line.Length && line[i + 1] == '"')
                {
                    currentField += '"';
                    i++;
                }
                else
                {
                    inQuotes = !inQuotes;
                }
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