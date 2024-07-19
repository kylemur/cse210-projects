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

    public Football(string team, float duration, string location, string playingSurface, int penalties, int pointsConceded, int touchdowns, int fieldGoals,  int PATs, int twoPt, int otherPoints, int yardsO, int yardsD, int turnovers) : base(team, duration, location, playingSurface, penalties)
    {
        _pointsConceded = pointsConceded;
        _touchdowns = touchdowns;
        _fieldGoals = fieldGoals;
        _PATs = PATs;
        _twoPt = twoPt;
        _otherPoints = otherPoints;
        _yardsO = yardsO;
        _yardsD = yardsD;
        _turnovers = turnovers;
        SetOutcome();
    }

    private void SetPoints()
    {
        _points = _touchdowns*6 + _fieldGoals*3 + _PATs + _twoPt*2 + _otherPoints;
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
        Console.WriteLine(_goals);
        Console.WriteLine(_goalsConceded);
        Console.WriteLine(_shots);
        Console.WriteLine(_shotsOnGoal);
        Console.WriteLine(_saves);
        Console.WriteLine(_penBoxMins);
    }
    
    
    

    public override void SaveAttributes(string team) // Save to a text file (updates existing file, otherwise creates new file)
    {
        string _attributes = $"{_goals}~{_goalsConceded}~{_shots}~{_shotsOnGoal}~{_saves}~{_penBoxMins}"; // Serialize attributes

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


                string[] lines = File.ReadAllLines(filename); // Get each line from the file
            
                string[] parts = lines[0].Split("~"); // Get points info

                _outcome = (Outcome)Enum.Parse(typeof(Outcome), parts[0]);
                _team = parts[1];
                _duration = float.Parse(parts[2]);
                _location = parts[3];
                _playingSurface = parts[4];
                _penalties = int.Parse(parts[5]);
                _goals = int.Parse(parts[6]);
                _goalsConceded = int.Parse(parts[7]);
                _shots = int.Parse(parts[8]);
                _shotsOnGoal = int.Parse(parts[9]);
                _saves = int.Parse(parts[10]);
                _penBoxMins = int.Parse(parts[11]);   
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