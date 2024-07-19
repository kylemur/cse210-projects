class Baseball : SportingEvent
{
    private int _runs;
    private int _runsConceded;
    private int _foulBalls;
    private int _strikes;
    private int _singles;
    private int _doubles;
    private int _triples;
    private int _homeRuns;

    public Baseball(string team, float duration, string location, string playingSurface, int penalties, int runs, int runsConceded, int foulBalls, int strikes,  int singles, int doubles, int triples, int homeRuns) : base(team, duration, location, playingSurface, penalties)
    {
        _goals = goals;
        _goalsConceded = goalsConceded;
        _shots = shots;
        _shotsOnGoal = shotsOnGoal;
        _saves = saves;
        _yellowCards = yellowCards;
        _redCards = redcards;
        SetOutcome();
    }

    public override void SetOutcome()
    {
        if (_goals > _goalsConceded)
        {
            _outcome = Outcome.Won;
        }
        else if (_goals == _goalsConceded)
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
        Console.WriteLine(_outcome);
        Console.WriteLine(_goals);
        Console.WriteLine(_goalsConceded);
        Console.WriteLine(_shots);
        Console.WriteLine(_shotsOnGoal);
        Console.WriteLine(_saves);
        Console.WriteLine(_yellowCards);
        Console.WriteLine(_redCards);
    }
    
    
    

    public override void SaveAttributes(string team) // Save to a text file (updates existing file, otherwise creates new file)
    {
        string _attributes = $"{_outcome}~{_team}~{_duration}~{_location}~{_playingSurface}~{_penalties}~{_goals}~{_goalsConceded}~{_shots}~{_shotsOnGoal}~{_saves}~{_yellowCards}~{_redCards}"; // Serialize attributes

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
                // string team, float duration, string location, string playingSurface, int penalties, int goals, int goalsConceded, int shots, int shotsOnGoal,  int saves, int yellowCards, int redcards


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
                _yellowCards = int.Parse(parts[11]);
                _redCards = int.Parse(parts[12]);        
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