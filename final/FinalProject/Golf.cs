class Golf : SportingEvent
{
    private int _totalStrokes = 0;
    private List<int> _pars = new();
    private List<int> _actuals = new();
    private int _ace = 0;
    private int _condor = 0;
    private int _albatross = 0;
    private int _eagle = 0;
    private int _birdie = 0;
    private int _par = 0;
    private int _bogey = 0;
    private int _twoBogey = 0;
    private int _threeBogey = 0;
    private int _moreBogey = 0;

    public Golf(string team="", float duration=0.0f, string location="", string playingSurface="", int penalties=0) : base(team, duration, location, playingSurface, penalties)
    {
        _class = "Golf";
        // SetOutcome();
        // SetPars();
        // SetActuals();
        // SetTotalStrokes();
        // SetNames();
    }

    public override int GetScore()
    {
        return _totalStrokes;
    }


    public void SetPars(string pars) // copilot helped me to deserialize a list
    {
        _pars = pars.Split(',').Select(int.Parse).ToList();
    }

    public void SetActuals(string actuals)
    {
        _actuals = actuals.Split(',').Select(int.Parse).ToList();
    }




    public void AddToPars()
    {
        for (int i=0; i<18; i++)
        {
            Console.Write($"Hole {i+1} par: ");
            _pars.Add(int.Parse(Console.ReadLine()));
        }
    }

    public void AddToActuals()
    {
        for (int i=0; i<18; i++)
        {
            Console.Write($"Hole {i+1} strokes: ");
            _actuals.Add(int.Parse(Console.ReadLine()));
        }
    }
    public void SetTotalStrokes()
    {
        foreach (int i in _actuals)
        {
            _totalStrokes += i;
        }
    }

    public void SetNames()
    {
        for (int i = 0; i < 18; i++)
        {
            if (_actuals[i] == 1)
            {
                _ace += 1;
            }
            if (_actuals[i] - _pars[i] == -4)
            {
                _condor += 1;
            }
            else if (_actuals[i] - _pars[i] == -3)
            {
                _albatross += 1;
            }
            else if (_actuals[i] - _pars[i] == -2)
            {
                _eagle += 1;
            }
            else if (_actuals[i] - _pars[i] == -1)
            {
                _birdie += 1;
            }
            else if (_actuals[i] == _pars[i])
            {
                _par += 1;
            }
            else if (_actuals[i] - _pars[i] == 1)
            {
                _bogey += 1;
            }
            else if (_actuals[i] - _pars[i] == 2)
            {
                _twoBogey += 1;
            }
            else if (_actuals[i] - _pars[i] == 3)
            {
                _threeBogey += 1;
            }
            else if (_actuals[i] - _pars[i] == 4)
            {
                _moreBogey += 1;
            }
        }
    }

    public override void SetOutcome()
    {
        Console.Write("Won, Tied, or Lost? ");
        _outcome = (Outcome)Enum.Parse(typeof(Outcome), Console.ReadLine());
    }

    public void PutOutcome(string outcome)
    {
        _outcome = (Outcome)Enum.Parse(typeof(Outcome), outcome);
    }

    
    public override void DisplayAttributes()
    {
        Console.WriteLine($"outcome: {_outcome}");
        Console.WriteLine($"name: {_team}");
        Console.WriteLine($"duration: {_duration} holes");
        Console.WriteLine($"location: {_location}");
        Console.WriteLine($"course type: {_playingSurface}");
        Console.WriteLine($"penalty strokes: {_penalties}");
        Console.WriteLine($"total strokes: {_totalStrokes}");
        Console.WriteLine($"holes-in-one: {_ace}");
        Console.WriteLine($"condors: {_condor}");
        Console.WriteLine($"albatrosses: {_albatross}");
        Console.WriteLine($"eagles: {_eagle}");
        Console.WriteLine($"birdies: {_birdie}");
        Console.WriteLine($"pars: {_par}");
        Console.WriteLine($"bogeys: {_bogey}");
        Console.WriteLine($"double bogeys: {_twoBogey}");
        Console.WriteLine($"triple bogeys: {_threeBogey}");
        Console.WriteLine($"quatruple+ bogeys: {_moreBogey}");
    }
    
    
    public override void SaveAttributes() // Save to a text file (updates existing file, otherwise creates new file)
    {
        string serializedPars = string.Join(",", _pars); // copilot helped me to serialize a list
        string serializedAct = string.Join(",", _actuals);

        string _attributes = $"{_outcome}~{_team}~{_duration}~{_location}~{_playingSurface}~{_penalties}~{serializedPars}~{serializedAct}"; // Serialize attributes

        string fileName = Path.Combine("Stats", $"{_class}.txt"); // I got this from GitHub Copilot.

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(_attributes);
        }
    }
}