using System;
using System.IO;

public class Journal
 {
private List<Entry> _journalEntries = new List<Entry>();

    public string fileName { get; private set; }

    public void AddEntry(Entry entry)
    {
        _journalEntries.Add(entry);
        
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _journalEntries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string file)
    {
        string fileName = "journal.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _journalEntries)
            {
                outputFile.WriteLine(entry);
            }
            
        }
    }

    public void LoadFromFile(string file)
    {
        Console.WriteLine(File.ReadAllText (file));
    }
}