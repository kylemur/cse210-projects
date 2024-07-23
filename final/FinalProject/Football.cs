class Football : SportingEvent
{
    private int _yardsPen = 0;
    private int _points = 0;
    private int _pointsConceded = 0;
    private int _touchdowns = 0;
    private int _fieldGoals = 0;
    private int _PATs = 0;
    private int _twoPt = 0;
    private int _otherPoints = 0;
    private int _yardsO = 0;
    private int _yardsD = 0;
    private int _turnovers = 0;

    public Football(string team = "", float duration = 0.0f, string location = "", string playingSurface = "", int penalties = 0, int yardsPen = 0, int pointsConceded = 0, int touchdowns = 0, int PATs = 0, int twoPt = 0, int fieldGoals = 0, int otherPoints = 0, int yardsO = 0, int yardsD = 0, int turnovers = 0) : base(team, duration, location, playingSurface, penalties)
    {
        _class = "Football";
        _yardsPen = yardsPen;
        _pointsConceded = pointsConceded;
        _touchdowns = touchdowns;
        _PATs = PATs;
        _twoPt = twoPt;
        _fieldGoals = fieldGoals;
        _otherPoints = otherPoints;
        _yardsO = yardsO;
        _yardsD = yardsD;
        _turnovers = turnovers;
        SetPoints();
        SetOutcome();
    }

    private void SetPoints()
    {
        _points = (_touchdowns*6) + _PATs + (_twoPt*2) + (_fieldGoals*3) + _otherPoints;
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
        Console.WriteLine($"field surface: {_playingSurface}");
        Console.WriteLine($"penalties: {_penalties}");
        Console.WriteLine($"yards penalized: {_yardsPen}");
        Console.WriteLine($"points: {_points}");
        Console.WriteLine($"points conceded: {_pointsConceded}");
        Console.WriteLine($"touchdowns: {_touchdowns}");
        Console.WriteLine($"PATs: {_PATs}");
        Console.WriteLine($"two point conversions: {_twoPt}");
        Console.WriteLine($"field goals: {_fieldGoals}");
        Console.WriteLine($"other points: {_otherPoints}");
        Console.WriteLine($"offensive yards: {_yardsO}");
        Console.WriteLine($"yards allowed: {_yardsD}");
        Console.WriteLine($"turnovers: {_turnovers}");
    }
    

    public override void SaveAttributes() // Save to a text file (updates existing file, otherwise creates new file)
    {
        string _attributes = $"{_team}~{_duration}~{_location}~{_playingSurface}~{_penalties}~{_yardsPen}~{_pointsConceded}~{_touchdowns}~{_PATs}~{_twoPt}~{_fieldGoals}~{_otherPoints}~{_yardsO}~{_yardsD}~{_turnovers}"; // Serialize attributes

        string fileName = Path.Combine("Stats", $"{_class}.txt"); // I got this from GitHub Copilot.

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(_attributes);
        }
    }

}