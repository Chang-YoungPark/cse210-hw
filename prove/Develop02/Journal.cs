using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public string _journalFile;
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        
    }

    public void Display()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        using (StreamWriter saveFile = new StreamWriter(_journalFile))
        {
            foreach(Entry entry in _entries)
            {
                saveFile.WriteLine($"{entry._journalDate}^{entry._ramdomPrompt}^{entry._journalData}");
            }
        }
    }
    
    public void LoadToFile()
    {
        string[] readData = System.IO.File.ReadAllLines(_journalFile);

        foreach (string line in readData)
        {
            Entry readEntry = new Entry();
            string[] data = line.Split("^");

            readEntry._journalDate = data[0];
            readEntry._ramdomPrompt = data[1];
            readEntry._journalData = data[2];

            _entries.Add(readEntry);

        }
    }

}