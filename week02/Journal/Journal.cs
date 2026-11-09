using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
public class Journal
{
    public List<string> _options = new List<string> { "1. Write", "2. Display", "3. Save", "4. Load", "5. Quit" };
    private readonly List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
        {
            using StreamWriter writer = new StreamWriter(file);
            foreach (Entry entry in _entries)
            {
                string json = JsonSerializer.Serialize(entry, options);
                writer.WriteLine(json);
            }
        }
    }

    public void LoadFromFile(string file)
    {
        string json = File.ReadAllText(file);
        List<Entry> loadedEntries = JsonSerializer.Deserialize<List<Entry>>(json);
        if (loadedEntries == null)
        {
            throw new FileNotFoundException($"The file {file} was not found.");
        }
        foreach (Entry entry in loadedEntries)
        {
            if  (entry == null
                || entry._date == null
                || entry._prompt == null
                || entry._entry == null)
            {
                throw new JsonException($"The file {file} contains an invalid journal entry.");
            }
        }

    _entries.Clear();
    _entries.AddRange(loadedEntries);
    }
}
