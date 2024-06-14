class Scripture
{
    private string _reference;
    private string _words;
    private List<string> _wordsList;
    private List<Word> _classList = new List<Word>();
    private Stack<int> _shownIndexes = new();
    private Stack<int> _hiddenIndexes = new();
    // List to store random indexes
    private List<int> randomIndexes = new List<int>();
    // Create a new Random instance
    private Random random = new Random();



    // public Scripture()
    // {
    //     Reference reference1 = new Reference();
    //     _reference = reference1.GetReference();
    //     _words = "Behold, it came to pass that I, Enos, knowing my father that he was a just man— for he taught me in his language, and also in the nurture and admonition of the Lord— and blessed be the name of my God for it— And I will tell you of the wrestle which I had before God, before I received a remission of my sins.";

    //     string[] _wordsArray = _words.Split(' ');
    //     _wordsList = _wordsArray.ToList();

    //     // Pick random indexes
    //     while (randomIndexes.Count < _wordsList.Count)
    //     {
    //         int randomIndex = random.Next(_wordsList.Count);
    //         if (!randomIndexes.Contains(randomIndex))
    //         {
    //             randomIndexes.Add(randomIndex);
    //         }
    //     }

    //     // put each i from randomIndexes into _shownIndexes
    //     foreach (int rndint in randomIndexes)
    //     {
    //         _shownIndexes.Push(rndint);
    //     }

    //     foreach (string wrd in _wordsList)
    //     {
    //         Word wrd1 = new Word(wrd);
    //         int index = _wordsList.IndexOf(wrd);
    //         if (_hiddenIndexes.Contains(index))
    //         {
    //             wrd1.Hide();
    //         }
    //         _classList.Add(wrd1);
    //     }
    // }




    public Scripture(string reference, string words)
    {
        _reference = reference;
        _words = words;

        string[] _wordsArray = _words.Split(' ');
        _wordsList = _wordsArray.ToList();

        // Pick random indexes
        while (randomIndexes.Count < _wordsList.Count)
        {
            int randomIndex = random.Next(_wordsList.Count);
            if (!randomIndexes.Contains(randomIndex))
            {
                randomIndexes.Add(randomIndex);
            }
        }

        // put each i from randomIndexes into _shownIndexes
        foreach (int rndint in randomIndexes)
        {
            _shownIndexes.Push(rndint);
        }

        foreach (string wrd in _wordsList)
        {
            Word wrd1 = new Word(wrd);
            int index = _wordsList.IndexOf(wrd);
            if (_hiddenIndexes.Contains(index))
            {
                wrd1.Hide();
            }
            _classList.Add(wrd1);
        }
    }




    public void HideOneWord()
    {
        if (_shownIndexes.Count > 0)
        {
            int indexToHide = _shownIndexes.Pop();
            _hiddenIndexes.Push(indexToHide);
        }

        _classList.Clear();

        foreach (string w in _wordsList)
        {
            Word w1 = new Word(w);
            int index = _wordsList.IndexOf(w);
            if (_hiddenIndexes.Contains(index))
            {
                w1.Hide();
            }
            _classList.Add(w1);
        }
    }

    public int ShownIndexesCount()
    {
        return _shownIndexes.Count();
    }

    public void Show()
    {
        Console.Write($"{_reference} ");

        foreach (Word j in _classList)
        {
            string showHide = j.Render();
            Console.Write(showHide);
        }
    }

    public void Undo()
    {
        if (_hiddenIndexes.Count > 0)
        {
            int indexToShow = _hiddenIndexes.Pop();
            _shownIndexes.Push(indexToShow);

            _classList.Clear();

            foreach (string w in _wordsList)
            {
                Word w1 = new Word(w);
                int index = _wordsList.IndexOf(w);
                if (_hiddenIndexes.Contains(index))
                {
                    w1.Hide();
                }
                _classList.Add(w1);
            }
        }
        else if (_hiddenIndexes.Count <= 0)
        {
            _classList.Clear();

            foreach (string w in _wordsList)
            {
                Word w1 = new Word(w);
                int index = _wordsList.IndexOf(w);
                if (_hiddenIndexes.Contains(index))
                {
                    w1.Hide();
                }
                _classList.Add(w1);
            }
        }
    }
}