namespace ScriptureMemorizer;

public class Reference
{
    private readonly string _bookName;
    private readonly int _chapterNumber;
    private readonly int _startingVerse;
    private readonly int? _endingVerse;

    public Reference(string bookName, int chapterNumber, int verse)
    {
        _bookName = bookName;
        _chapterNumber = chapterNumber;
        _startingVerse = verse;
        _endingVerse = null;
    }

    public Reference(string bookName, int chapterNumber, int startingVerse, int endingVerse)
    {
        _bookName = bookName;
        _chapterNumber = chapterNumber;
        _startingVerse = startingVerse;
        _endingVerse = endingVerse;
    }

    public string GetDisplayText()
    {
        if (_endingVerse.HasValue)
        {
            return $"{_bookName} {_chapterNumber}:{_startingVerse}-{_endingVerse}";
        }

        return $"{_bookName} {_chapterNumber}:{_startingVerse}";
    }
}