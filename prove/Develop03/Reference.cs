public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse = 0;


    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public void DisplayReference()
    {
        if (_endVerse == 0)
        {
            Console.Write($"{_book} {_chapter}:{_startVerse}");
        }

        else
        {
            Console.Write($"{_book} {_chapter}:{_startVerse}-{_endVerse}");
        }
    }
}