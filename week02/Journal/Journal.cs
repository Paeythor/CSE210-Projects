using System;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        // TO DO: implement file saving logic
    }

    public void LoadFromFile(string file)
    {
        // TO DO: implement file loading logic
    }
}



