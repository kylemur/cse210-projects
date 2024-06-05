class Scripture
{
    private string _reference;
    private string _words;
    private List<string> _wordsList;
    private List<Word> _classList = new List<Word>();
    private Stack<int> _shownIndexes = new();
    private Stack<int> _hiddenIndexes = new();

    public Scripture()
    {
        Reference reference1 = new Reference();
        _reference = reference1.GetReference();
        _words = "Behold, it came to pass that I, Enos, knowing my father that he was a just man— for he taught me in his language, and also in the nurture and admonition of the Lord— and blessed be the name of my God for it— And I will tell you of the wrestle which I had before God, before I received a remission of my sins.";

        Console.Write($"{_reference} ");

        string[] _wordsArray = _words.Split(' ');
        _wordsList = _wordsArray.ToList();

        // List to store random indexes
        List<int> randomIndexes = new List<int>();
        
        // Create a new Random instance
        Random random = new Random();
        
        /// make a list 0 through list length, take out 3 from that list, Hide() UNLESS index in this list

        // Pick random indexes
        while (randomIndexes.Count < _wordsList.Count)
        {
            int randomIndex = random.Next(_wordsList.Count);
            if (!randomIndexes.Contains(randomIndex))
            {
                randomIndexes.Add(randomIndex);
            }
        }

        // Stack<int> _shownIndexes = new();
        // Stack<int> _hiddenIndexes = new();

        
        // put each i from randomIndexes into _shownIndexes
        foreach (int rndint in randomIndexes)
        {
            _shownIndexes.Push(rndint);
        }

        // take first i from _shownIndexes and put it into _hiddenIndexes
        // while (_shownIndexes.Count > 0)
        // {
        //     int indexToHide = _shownIndexes.Pop();
        //     _hiddenIndexes.Push(indexToHide);
        // }
        
        
        // foreach (string w in _wordsList)
        // {
        //     Word w1 = new Word(w);
        //     int index = _wordsList.IndexOf(w);
        //     if (_hiddenIndexes.Contains(index))
        //     {
        //         w1.Hide();
        //     }
        //     _classList.Add(w1);
            
        // }

        // foreach (Word j in _classList)
        // {
        //     string showHide = j.Render();
        //     Console.Write(showHide);
        // }
    }




    public Scripture(string reference, string words)
    {
        _reference = reference;
        _words = words;

        Console.Write($"{_reference} ");

        string[] _wordsArray = words.Split(' ');
        _wordsList = _wordsArray.ToList();
        
        // List to store random indexes
        List<int> randomIndexes = new List<int>();
        
        // Create a new Random instance
        Random random = new Random();
        
        // Pick random indexes
        while (randomIndexes.Count < 3)
        {
            int randomIndex = random.Next(_wordsList.Count);
            if (!randomIndexes.Contains(randomIndex))
            {
                randomIndexes.Add(randomIndex);
            }
        }

        foreach (string w in _wordsList)
        {
            Word w1 = new Word(w);
            int index = _wordsList.IndexOf(w);
            if (randomIndexes.Contains(index))
            {
                w1.Hide();
            }
            _classList.Add(w1);
            
        }

        // foreach (Word j in _classList)
        // {
        //     string showHide = j.Render();
        //     Console.Write(showHide);
        // }

    }

    public void HideOneWord()
    {
        int indexToHide = _shownIndexes.Pop();
        _hiddenIndexes.Push(indexToHide);
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

    public void Show()
    {
        foreach (Word j in _classList)
        {
            string showHide = j.Render();
            Console.Write(showHide);
        }
    }
}