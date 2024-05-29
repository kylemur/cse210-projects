class Scripture
{
    private string _reference;
    private string _words;
    private List<string> _wordsList;
    private List<Word> _classList;

    public Scripture()
    {
        _reference = "Enos 1:1-2";
        _words = "Behold, it came to pass that I, Enos, knowing my father that he was a just man— for he taught me in his language, and also in the nurture and admonition of the Lord— and blessed be the name of my God for it— And I will tell you of the wrestle which I had before God, before I received a remission of my sins.";

        string[] _wordsArray = _words.Split(' ');
        _wordsList = _wordsArray.ToList();
    }
    public Scripture(string reference, string words)
    {
        _reference = reference;
        _words = words;

        string[] _wordsArray = words.Split(' ');
        _wordsList = _wordsArray.ToList();

        foreach (string w in _wordsList)
        {
            Word w1 = new Word(w);
            w1.Add(w);
            Word showHide = w1.Render();
        }
    }

    public List<string> GetWords()
    {
        return _wordsList;
    }
    public string GetScriptAndRef()
    {
        string both = $"{_reference} {_wordsList}";
        return both;
    }

}