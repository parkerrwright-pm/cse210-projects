public class Entry
{
    public string _date { get; }
    public string _promptText { get; }
    public string _entryText { get; }

    public Entry(string _date, string _promptText, string _entryText)
    {
        this._date = _date;
        this._promptText = _promptText;
        this._entryText = _entryText;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} - {_promptText}");
        Console.WriteLine(_entryText);
    }
}
