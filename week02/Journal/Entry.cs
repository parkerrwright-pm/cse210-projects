public class Entry
{
    public string _date { get; }
    public string _promptText { get; }
    public string _entryText { get; }

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - {_promptText}");
        Console.WriteLine(_entryText);
    }
}
