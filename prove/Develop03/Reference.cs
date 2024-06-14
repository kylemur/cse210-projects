using System.Collections.Concurrent;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verseFirst;
    private int _verseLast;
    private bool _multipleVerses;

    // public Reference()
    // {
    //     _book = "Enos";
    //     _chapter = 1;
    //     _verseFirst = 1;
    //     _verseLast = 2;
    //     _multipleVerses = true;
    // }
    public Reference(string book, int chapter, int verseFirst)
    {
        _book = book;
        _chapter = chapter;
        _verseFirst = verseFirst;
        _multipleVerses = false;
    }
    public Reference(string book, int chapter, int verseFirst, int verseLast)
    {
        _book = book;
        _chapter = chapter;
        _verseFirst = verseFirst;
        _verseLast = verseLast;
        _multipleVerses = true;
    }

    public string GetReference()
    {
        string reference;

        if (_multipleVerses)
        {
            reference = $"\n{_book} {_chapter}:{_verseFirst}-{_verseLast}";
        }
        else
        {
            reference = $"\n{_book} {_chapter}:{_verseFirst}";
        }
        return reference;
    }
}