class Word
{
    private string _word;

    public Word(string word)
    {
        _word = word;
        Show();
    }

    public bool Hide()
    {
        return false;
    }
    public bool Show()
    {
        return true;
    }
    public string Render()
    {
        if (Hide())
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