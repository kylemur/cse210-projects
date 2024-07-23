class Basketball : SportingEvent
{
    private int _points = 0;
    private int _pointsConceded = 0;
    private int _shots = 0;
    private int _shotsMade = 0;
    private double _shotPercent = 0;
    private int _threeShots = 0;
    private int _threeShotsMade = 0;
    private double _threePercent = 0;
    private int _freeThrows = 0;
    private int _freeMade = 0;
    private double _freePercent = 0;

    public Basketball(string team = "", float duration = 0.0f, string location = "", string playingSurface = "", int penalties = 0, int pointsConceded = 0, int shots = 0, int shotsMade = 0, int threeShots = 0, int threeShotsMade = 0, int freeThrows = 0, int freeMade = 0) : base(team, duration, location, playingSurface, penalties)
    {
        _class = "Basketball";
        _pointsConceded = pointsConceded;
        _shots = shots;
        _shotsMade = shotsMade;
        _threeShots = threeShots;
        _threeShotsMade = threeShotsMade;
        _freeThrows = freeThrows;
        _freeMade = freeMade;
        SetPoints();
        SetOutcome();
        SetShotPercent();
        SetThreePercent();
        SetFreePercent();
    }

    private void SetPoints()
    {
        _points = _shotsMade*2 + _threeShotsMade*3 + _freeMade;
    }

    public void SetShotPercent()
    {
        if (_shots > 0)
        {
            _shotPercent = 100 * _shotsMade / (double)_shots; // Cast to double for floating-point division
        }
    }
    public void SetThreePercent()
    {
        if (_threeShots > 0)
        {
            _threePercent = 100 * _threeShotsMade / (double)_threeShots; 
        }
    }
    public void SetFreePercent()
    {
        _freePercent = 100 * _freeMade / _freeThrows;
        if (_freeThrows > 0)
        {
            _freePercent = 100 * _freeMade / (double)_freeThrows; 
        }
    }

    

    public override void SetOutcome()
    {
        if (_points > _pointsConceded)
        {
            _outcome = Outcome.Won;
        }
        else if (_points == _pointsConceded)
        {
            _outcome = Outcome.Tied;
        }
        else
        {
            _outcome = Outcome.Lost;
        }
    }

    public override void DisplayAttributes()
    {
        Console.WriteLine($"outcome: {_outcome}");
        Console.WriteLine($"team: {_team}");
        Console.WriteLine($"duration: {_duration} minutes");
        Console.WriteLine($"location: {_location}");
        Console.WriteLine($"court surface: {_playingSurface}");
        Console.WriteLine($"fouls: {_penalties}");
        Console.WriteLine($"points: {_points}");
        Console.WriteLine($"points conceded: {_pointsConceded}");
        Console.WriteLine($"two point shots: {_shots}");
        Console.WriteLine($"two point shots made: {_shotsMade}");
        Console.WriteLine($"two point shooting %: {_shotPercent}%");
        Console.WriteLine($"three point shots: {_threeShots}");
        Console.WriteLine($"three pointers made: {_threeShotsMade}");
        Console.WriteLine($"three point shooting %: {_threePercent}%");
        Console.WriteLine($"free throws: {_freeThrows}");
        Console.WriteLine($"free throws made: {_freeMade}");
        Console.WriteLine($"free throw shooting %{_freePercent}%");
    }

    

    public override void SaveAttributes() // Save to a text file (updates existing file, otherwise creates new file)
    {
        string _attributes = $"{_outcome}~{_team}~{_duration}~{_location}~{_playingSurface}~{_penalties}~{_points}~{_pointsConceded}~{_shots}~{_shotsMade}~{_shotPercent}~{_threeShots}~{_threeShotsMade}~{_threePercent}~{_freeThrows}~{_freeMade}~{_freePercent}"; // Serialize attributes

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
    //             // {_points}~{_pointsConceded}~{_shots}~{_shotsMade}~{_shotPercent}~{_threeShots}~{_threeShotsMade}~{_threePercent}~{_freeThrows}~{_freeMade}~{_freePercent


    //             string[] lines = File.ReadAllLines(filename); // Get each line from the file
            
    //             string[] parts = lines[0].Split("~"); // Get points info

    //             _outcome = (Outcome)Enum.Parse(typeof(Outcome), parts[0]);
    //             _team = parts[1];
    //             _duration = float.Parse(parts[2]);
    //             _location = parts[3];
    //             _playingSurface = parts[4];
    //             _penalties = int.Parse(parts[5]);
    //             _points = int.Parse(parts[6]);
    //             _pointsConceded = int.Parse(parts[7]);
    //             _shots = int.Parse(parts[8]);
    //             _shotsMade = int.Parse(parts[9]);
    //             _shotPercent = double.Parse(parts[10]);
    //             _threeShots = int.Parse(parts[11]);
    //             _threeShotsMade = int.Parse(parts[12]);
    //             _threePercent = double.Parse(parts[13]);
    //             _freeThrows = int.Parse(parts[14]);
    //             _freeMade = int.Parse(parts[15]);
    //             _freePercent = double.Parse(parts[16]);
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