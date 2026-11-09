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
        using StreamWriter writer = new StreamWriter(file);
        foreach (Entry entry in _entries)
        {
            writer.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
        }
    }

    public void LoadFromFile(string file)
    {
        List<Entry> loadedEntries = new List<Entry>();
        string[] lines = File.ReadAllLines(file);

        for (int i = 0; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|', 3);
            if (parts.Length != 3)
            {
                throw new FormatException($"Invalid journal entry on line {i + 1}.");
            }

            loadedEntries.Add(new Entry(parts[0], parts[1], parts[2]));
        }

        _entries.Clear();
        _entries.AddRange(loadedEntries);
    }
}
