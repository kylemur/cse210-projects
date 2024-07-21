class Basketball : SportingEvent
{
    private int _points;
    private int _pointsConceded;
    private int _shots;
    private int _shotsMade;
    private double _shotPercent;
    private int _threeShots;
    private int _threeShotsMade;
    private double _threePercent;
    private int _freeThrows;
    private int _freeMade;
    private double _freePercent;

    public Basketball(string team, float duration, string location, string playingSurface, int penalties, int pointsConceded, int shots, int shotsMade, int threeShots, int threeShotsMade, int freeThrows, int freeMade) : base(team, duration, location, playingSurface, penalties)
    {
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
        else
        {
            _shotPercent = 0; // Set to 0 if no shots were taken
        }
    }
    public void SetThreePercent()
    {
        if (_threeShots > 0)
        {
            _threePercent = 100 * _threeShotsMade / (double)_threeShots; 
        }
        else
        {
            _threePercent = 0; 
        }
    }
    public void SetFreePercent()
    {
        _freePercent = 100 * _freeMade / _freeThrows;
        if (_freeThrows > 0)
        {
            _freePercent = 100 * _freeMade / (double)_freeThrows; 
        }
        else
        {
            _freePercent = 0; 
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
        Console.WriteLine(_outcome);
        Console.WriteLine(_team);
        Console.WriteLine(_duration);
        Console.WriteLine(_location);
        Console.WriteLine(_playingSurface);
        Console.WriteLine(_penalties);
        Console.WriteLine(_points);
        Console.WriteLine(_pointsConceded);
        Console.WriteLine(_shots);
        Console.WriteLine(_shotsMade);
        Console.WriteLine(_shotPercent);
        Console.WriteLine(_threeShots);
        Console.WriteLine(_threeShotsMade);
        Console.WriteLine(_threePercent);
        Console.WriteLine(_freeThrows);
        Console.WriteLine(_freeMade);
        Console.WriteLine(_freePercent);
    }

    

    public override void SaveAttributes() // Save to a text file (updates existing file, otherwise creates new file)
    {
        string _attributes = $"{_outcome}~{_team}~{_duration}~{_location}~{_playingSurface}~{_penalties}~{_points}~{_pointsConceded}~{_shots}~{_shotsMade}~{_shotPercent}~{_threeShots}~{_threeShotsMade}~{_threePercent}~{_freeThrows}~{_freeMade}~{_freePercent}"; // Serialize attributes

        string fileName = Path.Combine("Stats", $"{_team}Info.txt"); // I got this from GitHub Copilot.

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(_attributes);
        }
    }
    

    public override void LoadAttributes()
    {
        // Use Path.Combine for better path handling
        string filename = Path.Combine("Stats", $"{_team}Info.txt");

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
                // {_points}~{_pointsConceded}~{_shots}~{_shotsMade}~{_shotPercent}~{_threeShots}~{_threeShotsMade}~{_threePercent}~{_freeThrows}~{_freeMade}~{_freePercent


                string[] lines = File.ReadAllLines(filename); // Get each line from the file
            
                string[] parts = lines[0].Split("~"); // Get points info

                _outcome = (Outcome)Enum.Parse(typeof(Outcome), parts[0]);
                _team = parts[1];
                _duration = float.Parse(parts[2]);
                _location = parts[3];
                _playingSurface = parts[4];
                _penalties = int.Parse(parts[5]);
                _points = int.Parse(parts[6]);
                _pointsConceded = int.Parse(parts[7]);
                _shots = int.Parse(parts[8]);
                _shotsMade = int.Parse(parts[9]);
                _shotPercent = double.Parse(parts[10]);
                _threeShots = int.Parse(parts[11]);
                _threeShotsMade = int.Parse(parts[12]);
                _threePercent = double.Parse(parts[13]);
                _freeThrows = int.Parse(parts[14]);
                _freeMade = int.Parse(parts[15]);
                _freePercent = double.Parse(parts[16]);
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