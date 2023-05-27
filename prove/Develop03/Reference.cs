class Reference
{
    public Reference()
    {

    }

    private string _book;
    private string _chapter;
    private string _firstVerse;
    private string _lastVerse;

    public string DisplayText()
    {
        if (string.IsNullOrEmpty(_lastVerse))
        {
            return _book + " " + _chapter + ":" + _firstVerse; 
        }

        return _book + " " + _chapter + ":" + _firstVerse + "-" + _lastVerse; 
    }
}