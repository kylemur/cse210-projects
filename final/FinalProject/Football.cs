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
        string _attributes = $"{_outcome}~{_team}~{_duration}~{_location}~{_playingSurface}~{_penalties}~{_yardsPen}~{_points}~{_pointsConceded}~{_touchdowns}~{_PATs}~{_twoPt}~{_fieldGoals}~{_otherPoints}~{_yardsO}{_yardsD}~{_turnovers}"; // Serialize attributes

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


    //             string[] lines = File.ReadAllLines(filename); // Get each line from the file
            
    //             string[] parts = lines[0].Split("~"); // Get points info

    //             _outcome = (Outcome)Enum.Parse(typeof(Outcome), parts[0]);
    //             _team = parts[1];
    //             _duration = float.Parse(parts[2]);
    //             _location = parts[3];
    //             _playingSurface = parts[4];
    //             _penalties = int.Parse(parts[5]);
    //             _yardsPen = int.Parse(parts[6]);
    //             _points = int.Parse(parts[7]);
    //             _pointsConceded = int.Parse(parts[8]);
    //             _touchdowns = int.Parse(parts[9]);
    //             _PATs = int.Parse(parts[10]);
    //             _twoPt = int.Parse(parts[11]);
    //             _fieldGoals = int.Parse(parts[12]);
    //             _otherPoints = int.Parse(parts[13]);
    //             _yardsO = int.Parse(parts[14]);
    //             _yardsD = int.Parse(parts[15]);
    //             _turnovers = int.Parse(parts[16]);
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