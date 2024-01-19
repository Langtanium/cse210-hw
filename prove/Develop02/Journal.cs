using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    string quoteMark = "\"";

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry tempEntry in _entries)
        {
            Console.WriteLine($"Date: {tempEntry._date} - Prompt: {tempEntry._promptText}");
            Console.WriteLine($"{tempEntry._entryText}");
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        using(StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry tempEntry in _entries)
            {
                // Quotation marks in string
                // https://learn.microsoft.com/bs-latn-ba/dotnet/desktop/winforms/controls/how-to-put-quotation-marks-in-a-string-windows-forms?view=netframeworkdesktop-4.8
                outputFile.WriteLine($"{tempEntry._date},\"{tempEntry._promptText}\",\"{tempEntry._entryText}\"");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            Entry newEntry = new Entry();

            string[] parts = line.Split("," + quoteMark);

            newEntry._date = parts[0];
            newEntry._promptText = parts[1].TrimEnd(quoteMark.ToCharArray());
            newEntry._entryText = parts[2].TrimEnd(quoteMark.ToCharArray());

            _entries.Add(newEntry);
        }
    }

    public void ClearJournal()
    {
        _entries.Clear();
    }
}