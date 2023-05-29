using System.Text;
using System.Text.RegularExpressions;

class Scripture
{
    public Scripture()
    {
        this._reference = new Reference();
        this._words = new List<Word>();
        this._text = this.GetScripture();
       
        var temp_words = this._text.Split(" ");
        Regex rgx = new Regex("[^a-zA-Z]");
        var latestIndex = 0;

        // Removes non letter characters
        foreach (var word in temp_words)
        {
            var cleanWord = rgx.Replace(word, "");
            var index = this._text.IndexOf(word, latestIndex);
            latestIndex = index + 1;

            this._words.Add(new Word(cleanWord, index));
        }
    }

    private Reference _reference;
    private List<Word> _words;
    private string _text;


    public void HideWords()
    {
        int counter = 3;

        // Hide 3 random words
        while (counter > 0){
            var visible_words = _words.Where(w => !w.IsHidden());
            if (visible_words.Any()) {
                var visible_words_array = visible_words.ToArray();
                Random r = new Random();
                int n = r.Next(1, visible_words_array.Count());
                visible_words_array[n - 1].Hide();
            }

            counter--;
        }

    }

    public string GetRenderedText()
    {
        var renderedText = new StringBuilder();
        var indeces = new Dictionary<int, int>();

        foreach (var hiddenWord in this._words.Where(w => w.IsHidden()))
        {
            var index = hiddenWord.GetIndex();
            var text = hiddenWord.GetText();
            
            indeces.Add(index, text.Length);
        }

        for (int i = 0; i < this._text.Length; i++) 
        {
            if (indeces.Any(ind => ind.Key == i)) {
                var index = indeces.FirstOrDefault(ind => ind.Key == i);

                for (int j = 0; j < index.Value; j++) {
                    renderedText.Append("_");
                }

                i = i + index.Value - 1;
            }
            else{
                renderedText.Append(this._text[i]);
            }
        }

        return this._reference.DisplayText() + " " + renderedText.ToString();;
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }


    public string GetScripture()
    {
        Random r = new Random();
        int number = r.Next(1, 5);

        switch(number)
        {
            case 1:
            this._reference = new Reference("1 Nephi", 2, 15);
            this._text = "And my father dwelt in a tent.";
            return this._text;
            
            case 2:
            this._reference = new Reference("Proverbs", 21, 9);
            this._text = "It is better to dwell in a corner of the housetop, than with a brawling woman in a wide house.";
            return this._text;
            
            case 3:
            this._reference = new Reference("Ecclesiastes", 10, 19);
            this._text = "A feast is made for laughter, and wine maketh merry; but money answereth all things.";
            return this._text;
            
            case 4:
            this._reference = new Reference("Deuteronomy", 23, 1);
            this._text = "He that is wounded in the stones, or hath his privy member cut off, shall not enter into the congregation of the Lord.";
            return this._text;

            case 5:
            this._reference = new Reference("Proverbs", 27, 15, 16);
            this._text = "15. A continual dropping in a very rainy day and a contentious woman are alike. 16. Whosoever hideth her hideth the wind, and the ointment of his right hand, which bewrayeth itself.";
            return this._text;
        }

            this._reference = new Reference("2 Samuel", 10, 4);
            this._text = "Wherefore Hanin took David's servants, and shaved off the one half of their beards, and cut off their garments in the middle, even to their buttocks, and sent them away.";
            return this._text;
    }
}