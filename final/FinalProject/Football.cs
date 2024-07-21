class Football : SportingEvent
{
    private int _points;
    private int _pointsConceded;
    private int _touchdowns;
    private int _fieldGoals;
    private int _PATs;
    private int _twoPt;
    private int _otherPoints;
    private int _yardsO;
    private int _yardsD;
    private int _turnovers;

    public Football(string team, float duration, string location, string playingSurface, int penalties, int pointsConceded, int touchdowns, int PATs, int twoPt, int fieldGoals, int otherPoints, int yardsO, int yardsD, int turnovers) : base(team, duration, location, playingSurface, penalties)
    {
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
        Console.WriteLine(_outcome);
        Console.WriteLine(_team);
        Console.WriteLine(_duration);
        Console.WriteLine(_location);
        Console.WriteLine(_playingSurface);
        Console.WriteLine(_penalties);
        Console.WriteLine(_points);
        Console.WriteLine(_pointsConceded);
        Console.WriteLine(_touchdowns);
        Console.WriteLine(_PATs);
        Console.WriteLine(_twoPt);
        Console.WriteLine(_fieldGoals);
        Console.WriteLine(_otherPoints);
        Console.WriteLine(_yardsO);
        Console.WriteLine(_yardsD);
        Console.WriteLine(_turnovers);
    }
    
    
    

    public override void SaveAttributes() // Save to a text file (updates existing file, otherwise creates new file)
    {
        string _attributes = $"{_outcome}~{_team}~{_duration}~{_location}~{_playingSurface}~{_penalties}~{_points}~{_pointsConceded}~{_touchdowns}~{_PATs}~{_twoPt}~{_fieldGoals}~{_otherPoints}~{_yardsO}{_yardsD}~{_turnovers}"; // Serialize attributes

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
                _touchdowns = int.Parse(parts[8]);
                _PATs = int.Parse(parts[9]);
                _twoPt = int.Parse(parts[10]);
                _fieldGoals = int.Parse(parts[11]);
                _otherPoints = int.Parse(parts[12]);
                _yardsO = int.Parse(parts[13]);
                _yardsD = int.Parse(parts[14]);
                _turnovers = int.Parse(parts[15]);
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