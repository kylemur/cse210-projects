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

}