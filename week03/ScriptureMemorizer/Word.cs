class Word
{
    private bool _isHidden;
    private string _text;

    public Word(string text)
    {
        _isHidden = false;
        _text = text;
    }

    public void Hide()
    {
        if (!_isHidden)
        {
            _isHidden = true;
        }
    }
    public void Show()
    {
        if (_isHidden)
        {
            _isHidden = false;
        }
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            string word = "";
            foreach(char letter in _text)
            {
                word += "_";
            }
            return word;
        }
        return _text;
    }
}