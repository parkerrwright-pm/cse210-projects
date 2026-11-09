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
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        string json = JsonSerializer.Serialize(_entries, options);
        File.WriteAllText(file, json);
    }

    public void LoadFromFile(string file)
    {
        string json = File.ReadAllText(file);
        List<Entry> loadedEntries =
            JsonSerializer.Deserialize<List<Entry>>(json);

        if (loadedEntries == null)
        {
            throw new JsonException("The file does not contain a journal.");
        }

        foreach (Entry entry in loadedEntries)
        {
            if (entry == null ||
                entry._date == null ||
                entry._promptText == null ||
                entry._entryText == null)
            {
                throw new JsonException(
                    $"The file {file} contains an invalid journal entry.");
            }
        }

        _entries.Clear();
        _entries.AddRange(loadedEntries);
    }
}