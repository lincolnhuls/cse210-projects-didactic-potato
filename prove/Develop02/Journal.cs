using System;
using System.Collections.Generic;
using System.IO;

public class Journal {
    public List<Entry> _entries = new List<Entry>();

    public void Display() {
        foreach (Entry entry in _entries) {
            entry.Display();
        }
    }
    public void Write(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"|{entry._entryDateTime}|{entry._prompt}|{entry._entryText}");
            }
        }
    }
    public void Load(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry entry = new Entry();
            entry._entryDateTime = parts[1];
            entry._prompt = parts[2];
            entry._entryText = parts[3];
            _entries.Add(entry);
        }
    }
}