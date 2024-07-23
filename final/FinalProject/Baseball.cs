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

}