using System.Text.RegularExpressions;

class Scripture
{
    public Scripture()
    {
        // _text = this.GetScripture();
        // var temp_words = this._text.Split() + " ";
        // foreach (var word in temp_words)
        // {
        //     // Regex.Replace(word, @"[^\w\s]", "");
        // }
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
        // return this._text;
        return "";
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
            return "1 Nephi 2 '15. And my father qwelt in a tent.'";
            
            case 2:
            return "Proverbs 21 '9. It is better to dwell in a corner of the housetop, than with a brawling woman in a wide house.'";
            
            case 3:
            return "Ecclesiastes 10 '19. A feast is made for laughter, and wine maketh merry: but money answereth all things.'";
            
            case 4:
            return "Deuteronomy 23 '1. He that is wounded in the stones, or hath his privy member cut off, shall not enter into the congregation of the Lord.'";

            case 5:
            return "Proverbs 27 '15. A continual dropping is a very rainy day and a contentious woman are alike. 16. Whosoever hideth her hideth the wond, and the ointment of his right hand, which bewrayeth itself.'";
        }

        return "2 Samuel 10 '4. Wherefore Hanin took David's servants, and shaved off the one half of their beards, and cut off their garments in the middle, even to their buttocks, and sent them away.'";
    }
}