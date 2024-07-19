class Golf : SportingEvent
{
    private int _totalStrokes;
    private List<int> _pars = new();
    private List<int> _actuals = new();
    private int _ace;
    private int _condor;
    private int _albatross;
    private int _eagle;
    private int _birdie;
    private int _par;
    private int _bogey;
    private int _twoBogey;
    private int _threeBogey;
    private int _moreBogey;

    public Golf(string team, float duration, string location, string playingSurface, int penalties) : base(team, duration, location, playingSurface, penalties)
    {
        SetOutcome();
        SetPars();
        SetActuals();
        SetTotalStrokes();
        SetNames();
    }

    public void SetPars()
    {
        // for (int i=1, i=18, i++)
        // {
        //     Console.Write($"Hole {i} par: ");
        //     int parOne = int.Parse(Console.ReadLine());
        //     _pars.Add(parOne);
        // }
    }

    public void SetActuals()
    {
        // for (int i=1, i=18, i++)
        // {
        //     Console.Write($"Hole {i} strokes: ");
        //     int actualOne = int.Parse(Console.ReadLine());
        //     _pars.Add(actualOne);
        // }
    }
    public void SetTotalStrokes()
    {
        foreach (int i in _actuals)
        {
            _totalStrokes += i;
        }
    }

    private void SetNames()
    {
        foreach (int a in _actuals)
        {
            
        }
        foreach (int p in _pars)
        {
            // if a == 1 then _ace += 1
            // if a - p == -4 then _condor += 1
            // if a - p == -3 then _albatross += 1
            // if a - p == -2 then _eagle += 1
            // if a - p == -1 then _birdie += 1
            // if a - p == 0 then _par += 1
            // if a - p == 1 then _bogey += 1
            // if a - p == 2 then _twoBogey += 1
            // if a - p == 3 then _threeBogey += 1
            // if a - p >= 4 then _moreBogey += 1
        }
    }


    public override void SetOutcome()
    {
        Console.Write("Won, Tied, or Lost? ");
        _outcome = (Outcome)Enum.Parse(typeof(Outcome), Console.ReadLine());
    }

    
    public override void DisplayAttributes()
    {
        Console.WriteLine(_outcome);
        Console.WriteLine(_team);
        Console.WriteLine(_duration);
        Console.WriteLine(_location);
        Console.WriteLine(_playingSurface);
        Console.WriteLine(_penalties);
        Console.WriteLine(_totalStrokes);
        Console.WriteLine(_ace);
        Console.WriteLine(_condor);
        Console.WriteLine(_albatross);
        Console.WriteLine(_eagle);
        Console.WriteLine(_birdie);
        Console.WriteLine(_par);
        Console.WriteLine(_bogey);
        Console.WriteLine(_twoBogey);
        Console.WriteLine(_threeBogey);
        Console.WriteLine(_moreBogey);
    }
    
    
    

    public override void SaveAttributes(string team) // Save to a text file (updates existing file, otherwise creates new file)
    {
        string _attributes = $"{_outcome}~{_team}~{_duration}~{_location}~{_playingSurface}~{_penalties}~{_totalStrokes}~{_ace}~{_condor}~{_albatross}~{_eagle}~{_birdie}~{_par}~{_bogey}~{_twoBogey}~{_threeBogey}~{_moreBogey}"; // Serialize attributes

        string fileName = Path.Combine("Stats", $"{team}Info.txt"); // I got this from GitHub Copilot.

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(_attributes);
        }
    }
    

    public override void LoadAttributes(string team)
    {
        // Use Path.Combine for better path handling
        string filename = Path.Combine("Stats", $"{team}Info.txt");

        // Check if the file exists before attempting to read
        if (File.Exists(filename))
        {
            try
            {
                // _pointsAttributes = "0~0~0~0"; // Reset values before loading from a file
                // _totalPoints = 0;
                // _simplePoints = 0;
                // _eternalPoints = 0;
                // _checklistPoints = 0;

                // _goalsList.Clear();
                // {_foulBalls}~{_strikes}~{_singles}~{_doubles}~{_triples}~{_homeRuns}


                string[] lines = File.ReadAllLines(filename); // Get each line from the file
            
                string[] parts = lines[0].Split("~"); // Get points info

                _outcome = (Outcome)Enum.Parse(typeof(Outcome), parts[0]);
                _team = parts[1];
                _duration = float.Parse(parts[2]);
                _location = parts[3];
                _playingSurface = parts[4];
                _penalties = int.Parse(parts[5]);
                _totalStrokes = int.Parse(parts[6]);
                _ace = int.Parse(parts[7]);
                _condor = int.Parse(parts[8]);
                _albatross = int.Parse(parts[9]);
                _eagle = int.Parse(parts[10]);
                _birdie = int.Parse(parts[11]);
                _par = int.Parse(parts[12]);
                _bogey = int.Parse(parts[13]);
                _twoBogey = int.Parse(parts[14]);
                _threeBogey = int.Parse(parts[15]);
                _moreBogey = int.Parse(parts[16]);
            }
            catch (IOException ex)
            {
                // Handle potential IO exceptions (e.g., file is being used by another process)
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
        
    }

}