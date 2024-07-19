class Basketball : SportingEvent
{
    private int _points;
    private int _pointsConceded;
    private int _shots;
    private int _shotsMade;
    private int _shotPercent;
    private int _threeShots;
    private int _threeShotsMade;
    private int _threePercent;
    private int _freeThrows;
    private int _freeMade;
    private int _freePercent;

    public Basketball(string team, float duration, string location, string playingSurface, int penalties, int pointsConceded, int shots, int shotsMade,  int saves, int threeShots, int threeShotsMade, int freeThrows, int freeMade) : base(team, duration, location, playingSurface, penalties)
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
        _shotPercent = (_shotsMade/_shots) * 100;
    }
    public void SetThreePercent()
    {
        _threePercent = (_threeShotsMade/_threeShots) * 100;
    }
    public void SetFreePercent()
    {
        _freePercent = (_freeMade/_freeThrows) * 100;
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

    

    public override void SaveAttributes(string team) // Save to a text file (updates existing file, otherwise creates new file)
    {
        string _attributes = $"{_outcome}~{_team}~{_duration}~{_location}~{_playingSurface}~{_penalties}~{_points}~{_pointsConceded}~{_shots}~{_shotsMade}~{_shotPercent}~{_threeShots}~{_threeShotsMade}~{_threePercent}~{_freeThrows}~{_freeMade}~{_freePercent}"; // Serialize attributes

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
                _shotPercent = int.Parse(parts[10]);
                _threeShots = int.Parse(parts[11]);
                _threeShotsMade = int.Parse(parts[12]);
                _threePercent = int.Parse(parts[13]);
                _freeThrows = int.Parse(parts[14]);
                _freeMade = int.Parse(parts[15]);
                _freePercent = int.Parse(parts[16]);
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