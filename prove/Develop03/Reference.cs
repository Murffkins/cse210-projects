class Reference
{
    public Reference()
    {

    }

    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int? _lastVerse;
    private string _reference;


    // When there is only one verse
    public Reference(string book, int chapter, int firstVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._firstVerse = firstVerse;
    }

    // When there is a second verse
    public Reference(string book, int chapter, int firstVerse, int lastVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._firstVerse = firstVerse;
        this._lastVerse = lastVerse;
    }

    public string DisplayText()
    {
        if (this._lastVerse == null)
        {
            _reference = $"{_book} {_chapter}:{_firstVerse}";
        }
        else{
            _reference = $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
        }
        return _reference;
    }
}