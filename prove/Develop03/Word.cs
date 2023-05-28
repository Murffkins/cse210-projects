using System.Text;

class Word{

    public Word()
    {

    }

    public Word(string text, int index){
        this._text = text;
        this._index = index;
    }

    private int _index;
    private bool _isHidden;
    private string _text;

    public void Hide()
    {
        _isHidden = true;
    }

        public void Show()
    {
        _isHidden = false;
    }

        public bool IsHidden()
    {
        return _isHidden;
    }

    public int GetIndex() {
        return this._index;
    }

    public string GetText() {
        return this._text;
    }

        public string GetRenderedText()
    {
        if (_isHidden)
        {
            // Adds the same number of underscores as letters in the words
            StringBuilder response = new StringBuilder();
            for (int i = 0; i < _text.Length; i++)
            {
                response.Append("_");
            }
            return response.ToString();
            
        }
        else
        {
            return _text;
        }
    }
}