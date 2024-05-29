class Word
{
    private List<string> _wordsList;
    private string _word;

    public Word(string word)
    {
        // set word to hidden or shown
            // for length of _wordsList, randomly choose 3 indexes in that list to hide
            // each new instance, hide 3 more (keep old hidden words still hidden)
        _word = word;
        Show();
    }

    private void SetWordsList()
    {
        Scripture scriptureWords = new Scripture();
        _wordsList = scriptureWords.GetWords();
    }
    public bool Hide()
    {
        return true;
    }
    public bool Show()
    {
        return true;
    }
    public string Render()
    {
        
        
        if (_randomWord = hide)
        {
            _lengthOfWord
            _wordHidden = "_" * _lengthOfWord;
            return _wordHidden;
        }
        else
        {
            return $"{_word} ";
        }
    }
}