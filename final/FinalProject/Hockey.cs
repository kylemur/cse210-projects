class Hockey : SportingEvent
{
    private int _goals = 0;
    private int _goalsConceded = 0;
    private int _shots = 0;
    private int _shotsOnGoal = 0;
    private int _saves = 0;
    private int _penBoxMins = 0;

    public Hockey(string team = "", float duration = 0.0f, string location = "", string playingSurface = "", int penalties = 0, int goals = 0, int goalsConceded = 0, int shots = 0, int shotsOnGoal = 0, int saves = 0, int penBoxMins = 0) : base(team, duration, location, playingSurface, penalties)
    {
        _class = "Hockey";
        _goals = goals;
        _goalsConceded = goalsConceded;
        _shots = shots;
        _shotsOnGoal = shotsOnGoal;
        _saves = saves;
        _penBoxMins = penBoxMins;
        SetOutcome();
    }

    public override int GetScore()
    {
        return _goals;
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
        Console.WriteLine($"outcome: {_outcome}");
        Console.WriteLine($"team: {_team}");
        Console.WriteLine($"duration: {_duration} minutes");
        Console.WriteLine($"location: {_location}");
        Console.WriteLine($"surface material: {_playingSurface}");
        Console.WriteLine($"number of fouls: {_penalties}");
        Console.WriteLine($"goals: {_goals}");
        Console.WriteLine($"goals conceded: {_goalsConceded}");
        Console.WriteLine($"shots: {_shots}");
        Console.WriteLine($"shots on goal: {_shotsOnGoal}");
        Console.WriteLine($"saves: {_saves}");
        Console.WriteLine($"minutes in penalty box: {_penBoxMins}");
    }
    

    public override void SaveAttributes() // Save to a text file (updates existing file, otherwise creates new file)
    {
        string _attributes = $"{_outcome}~{_team}~{_duration}~{_location}~{_playingSurface}~{_penalties}~{_goals}~{_goalsConceded}~{_shots}~{_shotsOnGoal}~{_saves}~{_penBoxMins}"; // Serialize attributes

        string fileName = Path.Combine("Stats", $"{_class}.txt"); // I got this from GitHub Copilot.

        using (StreamWriter outputFile = new StreamWriter(fileName, true))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(_attributes);
        }
    }

}