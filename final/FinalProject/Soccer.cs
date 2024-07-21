class Soccer : SportingEvent
{
    private int _goals = 0;
    private int _goalsConceded = 0;
    private int _shots = 0;
    private int _shotsOnGoal = 0;
    private int _saves = 0;
    private int _yellowCards = 0;
    private int _redCards = 0;

    public Soccer(string team = "", float duration = 0.0f, string location = "", string playingSurface = "", int penalties = 0, int goals = 0, int goalsConceded = 0, int shots = 0, int shotsOnGoal = 0, int saves = 0, int yellowCards = 0, int redCards = 0) : base(team, duration, location, playingSurface, penalties)
    {
        _class = "Soccer";
        _goals = goals;
        _goalsConceded = goalsConceded;
        _shots = shots;
        _shotsOnGoal = shotsOnGoal;
        _saves = saves;
        _yellowCards = yellowCards;
        _redCards = redCards;
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
        Console.WriteLine($"outcome: {_outcome}");
        Console.WriteLine($"team: {_team}");
        Console.WriteLine($"duration: {_duration} minutes");
        Console.WriteLine($"location: {_location}");
        Console.WriteLine($"field surface: {_playingSurface}");
        Console.WriteLine($"number of fouls: {_penalties}");
        Console.WriteLine($"goals: {_goals}");
        Console.WriteLine($"goals conceded: {_goalsConceded}");
        Console.WriteLine($"shots: {_shots}");
        Console.WriteLine($"shots on goal: {_shotsOnGoal}");
        Console.WriteLine($"saves: {_saves}");
        Console.WriteLine($"yellow cards: {_yellowCards}");
        Console.WriteLine($"red cards: {_redCards}");
    }
    
    
    

    public override void SaveAttributes() // Save to a text file (updates existing file, otherwise creates new file)
    {
        string _attributes = $"{_outcome}~{_team}~{_duration}~{_location}~{_playingSurface}~{_penalties}~{_goals}~{_goalsConceded}~{_shots}~{_shotsOnGoal}~{_saves}~{_yellowCards}~{_redCards}"; // Serialize attributes

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
        // string filename = Path.Combine("Stats", $"{_team}Info.txt");

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


                // else if (goalsParts[0] == "ChecklistGoal") // Get goal type and create a new ChecklistGoal object with the info
                //     {
                //         ChecklistGoal checklistGoal1 = new();
                //         checklistGoal1.SetGoalType(goalsParts[0]);
                //         checklistGoal1.SetName(goalsParts[1]);
                //         checklistGoal1.SetDescription(goalsParts[2]);
                //         checklistGoal1.SetCompleted(Convert.ToBoolean(goalsParts[3]));
                //         checklistGoal1.SetPointValue(Convert.ToInt16(goalsParts[4]));
                //         checklistGoal1.SetBonusPoints(int.Parse(goalsParts[5]));
                //         checklistGoal1.SetTimesCompleted(int.Parse(goalsParts[6]));
                //         checklistGoal1.SetTimesNeeded(int.Parse(goalsParts[7]));

                //         _goalsList.Add(checklistGoal1);
                //     }
                // }

}