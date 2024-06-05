class Word
{
    private string _word;
    private bool _ishidden;

    public Word(string word)
    {
        _word = word;
        Show();
    }

    public void Hide()
    {
        _ishidden = true;
    }
    public void Show()
    {
        _ishidden = false;
    }
    public string Render()
    {
        if (_ishidden)
        {
            int _length = _word.Length;
            string _wordHidden = new string('_', _length);
            // if character == alphabet then don't change, else _

            return $"{_wordHidden} ";
        }
        else
        {
            return $"{_word} ";
        }
    }
}