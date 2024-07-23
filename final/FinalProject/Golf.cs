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


    // public void SetPars(int par)
    // {
    //     _pars.Add(par);
    // }

    // public void SetPars(int par)
    // {
    //     _pars.Add(par);
    // }

    // public void SetPars(List<int> pars)
    // {
    //     foreach (int par in pars)
    //     {
    //         _pars.Add(par);
    //     }
    // }

    // public void SetActuals(List<int> actuals)
    // {
    //     foreach (int actual in actuals)
    //     {
    //         _actuals.Add(actual);
    //     }
    // }

    // public void SetPars(List<int> pars)
    // {
    //     _pars = pars;
    // }

    // public void SetActuals(List<int> actuals)
    // {
    //     _actuals = actuals;
    // }

    public void SetPars(string pars)
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

    // public void SetNames()
    // {
    //     // Reset counts to 0 to avoid accumulating values from multiple calls
    //     _ace = 0;
    //     _condor = 0;
    //     _albatross = 0;
    //     _eagle = 0;
    //     _birdie = 0;
    //     _par = 0; // Assuming there's a field _par to count pars
    //     _bogey = 0; // Assuming there's a field _bogey to count bogeys
    //     // Add more fields as necessary for other scores like double bogey, triple bogey, etc.

    //     for (int i = 0; i < 18; i++) // Ensure _actuals.Length is used for flexibility
    //     {
    //         int difference = _actuals[i] - _pars[i];
    //         switch (difference)
    //         {
    //             case -4:
    //                 _condor += 1;
    //                 break;
    //             case -3:
    //                 _albatross += 1;
    //                 break;
    //             case -2:
    //                 _eagle += 1;
    //                 break;
    //             case -1:
    //                 _birdie += 1;
    //                 break;
    //             case 0:
    //                 _par += 1;
    //                 break;
    //             case 1:
    //                 _bogey += 1;
    //                 break;
    //             // Add cases for double bogey, triple bogey, etc., if needed
    //             default:
    //                 if (_actuals[i] == 1) // Handle ace separately as it doesn't depend on _pars
    //                 {
    //                     _ace += 1;
    //                 }
    //                 break;
    //         }
    //     }
    // }


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

        // string _attributes = $"{_outcome}~{_team}~{_duration}~{_location}~{_playingSurface}~{_penalties}~{_totalStrokes}~{serializedPars}~{serializedAct}~{_ace}~{_condor}~{_albatross}~{_eagle}~{_birdie}~{_par}~{_bogey}~{_twoBogey}~{_threeBogey}~{_moreBogey}"; // Serialize attributes

        string _attributes = $"{_outcome}~{_team}~{_duration}~{_location}~{_playingSurface}~{_penalties}~{serializedPars}~{serializedAct}"; // Serialize attributes

        string fileName = Path.Combine("Stats", $"{_class}.txt"); // I got this from GitHub Copilot.

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(_attributes);
        }
    }
    

    // public override void LoadAttributes(string filename)
    // {
    //     // Use Path.Combine for better path handling
    //     // string filename = Path.Combine("Stats", $"{_team}Info.txt");

    //     // Check if the file exists before attempting to read
    //     if (File.Exists(filename))
    //     {
    //         try
    //         {
    //             // _pointsAttributes = "0~0~0~0"; // Reset values before loading from a file
    //             // _totalPoints = 0;
    //             // _simplePoints = 0;
    //             // _eternalPoints = 0;
    //             // _checklistPoints = 0;

    //             // _goalsList.Clear();
    //             // {_foulBalls}~{_strikes}~{_singles}~{_doubles}~{_triples}~{_homeRuns}


    //             string[] lines = File.ReadAllLines(filename); // Get each line from the file
            
    //             string[] parts = lines[0].Split("~"); // Get points info

    //             _outcome = (Outcome)Enum.Parse(typeof(Outcome), parts[0]);
    //             _team = parts[1];
    //             _duration = float.Parse(parts[2]);
    //             _location = parts[3];
    //             _playingSurface = parts[4];
    //             _penalties = int.Parse(parts[5]);
    //             _totalStrokes = int.Parse(parts[6]);


    //             // _pars = List<int>.Parse(parts[7]);
    //             // _actuals = List<int>.Parse(parts[8]);

    //             // List<int> myList = new List<int> {1, 2, 3, 4, 5};
    //             // string serializedList = string.Join(",", myList);
    //             // List<int> deserializedList = serializedList.Split(',').Select(int.Parse).ToList();

    //             _pars = parts[6].Split(',').Select(int.Parse).ToList();
    //             // _actuals = parts[8].Split(',').Select(int.Parse).ToList();
    //             // _actuals = parts[8].Split(',').Select<string, int>(Func<string, int> selector);
    //             _actuals = parts[7].Split(',').Select(s => int.Parse(s)).ToList();

    //             _ace = int.Parse(parts[9]);
    //             _condor = int.Parse(parts[10]);
    //             _albatross = int.Parse(parts[11]);
    //             _eagle = int.Parse(parts[12]);
    //             _birdie = int.Parse(parts[13]);
    //             _par = int.Parse(parts[14]);
    //             _bogey = int.Parse(parts[15]);
    //             _twoBogey = int.Parse(parts[16]);
    //             _threeBogey = int.Parse(parts[17]);
    //             _moreBogey = int.Parse(parts[18]);
    //         }
    //         catch (IOException ex)
    //         {
    //             // Handle potential IO exceptions (e.g., file is being used by another process)
    //             Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
    //         }
    //     }
    //     else
    //     {
    //         Console.WriteLine("File does not exist.");
    //     }
        
    // }

}