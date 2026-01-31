class Scripture
{
    Reference _reference;
    List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");
        foreach(string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random randomGenerator = new Random();

        int numberHidden = 0;
        while(numberHidden != numberToHide && !IsCompletelyHidden())
        {
            int wordToHide = randomGenerator.Next(0,_words.Count);
            if(!_words[wordToHide].IsHidden())
            {
                _words[wordToHide].Hide();
                numberHidden += 1;
            }
        }
    }
    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + " ";
        foreach(Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }
        return text;
    }
    public bool IsCompletelyHidden()
    {
        foreach(Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}