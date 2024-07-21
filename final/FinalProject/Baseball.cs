class Baseball : SportingEvent
{
    private int _runs = 0;
    private int _runsConceded = 0;
    private int _foulBalls = 0;
    private int _strikes = 0;
    private int _singles = 0;
    private int _doubles = 0;
    private int _triples = 0;
    private int _homeRuns = 0;

    public Baseball(string team="", float duration=0.0f, string location="", string playingSurface="", int penalties=0, int runs=0, int runsConceded=0, int foulBalls=0, int strikes=0,  int singles=0, int doubles=0, int triples=0, int homeRuns=0) : base(team, duration, location, playingSurface, penalties)
    {
        _class = "Baseball";
        _runs = runs;
        _runsConceded = runsConceded;
        _foulBalls = foulBalls;
        _strikes = strikes;
        _singles = singles;
        _doubles = doubles;
        _triples = triples;
        _homeRuns = homeRuns;
        SetOutcome();
    }


    public override void SetOutcome()
    {
        if (_runs > _runsConceded)
        {
            _outcome = Outcome.Won;
        }
        else if (_runs == _runsConceded)
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
        Console.WriteLine($"duration: {_duration} innings");
        Console.WriteLine($"location: {_location}");
        Console.WriteLine($"field surface: {_playingSurface}");
        Console.WriteLine($"penalties: {_penalties}");
        Console.WriteLine($"runs: {_runs}");
        Console.WriteLine($"runs conceded: {_runsConceded}");
        Console.WriteLine($"foul balls: {_foulBalls}");
        Console.WriteLine($"strikes: {_strikes}");
        Console.WriteLine($"singles: {_singles}");
        Console.WriteLine($"doubles: {_doubles}");
        Console.WriteLine($"triples: {_triples}");
        Console.WriteLine($"home runs: {_homeRuns}");
    }
    
    
    

    public override void SaveAttributes() // Save to a text file (updates existing file, otherwise creates new file)
    {
        string _attributes = $"{_outcome}~{_team}~{_duration}~{_location}~{_playingSurface}~{_penalties}~{_runs}~{_runsConceded}~{_foulBalls}~{_strikes}~{_singles}~{_doubles}~{_triples}~{_homeRuns}"; // Serialize attributes

        string fileName = Path.Combine("Stats", $"{_class}.txt"); // I got this from GitHub Copilot.

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(_attributes);
        }
    }
    

    public override void LoadAttributes(string filename)
    {
        // Use Path.Combine for better path handling
        //     string filename = Path.Combine("Stats", $"{_team}Info.txt");

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


                string[] lines = File.ReadAllLines(filename); // Get each line/event from the file
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split("~"); // Get info from each line/event

                    _outcome = (Outcome)Enum.Parse(typeof(Outcome), parts[0]);
                    _team = parts[1];
                    _duration = float.Parse(parts[2]);
                    _location = parts[3];
                    _playingSurface = parts[4];
                    _penalties = int.Parse(parts[5]);
                    _runs = int.Parse(parts[6]);
                    _runsConceded = int.Parse(parts[7]);
                    _foulBalls = int.Parse(parts[8]);
                    _strikes = int.Parse(parts[9]);
                    _singles = int.Parse(parts[10]);
                    _doubles = int.Parse(parts[11]);
                    _triples = int.Parse(parts[12]);
                    _homeRuns = int.Parse(parts[13]);
                }
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