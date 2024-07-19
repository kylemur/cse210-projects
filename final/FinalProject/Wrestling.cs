using System.Net.NetworkInformation;

class Wrestling : SportingEvent
{
    private int _points;
    private int _pointsConceded;
    private int _onePoint;
    private int _twoPoint;
    private int _fourPoint;
    private int _fivePoint;
    private bool _pin;

    public Wrestling(string team, float duration, string location, string playingSurface, int penalties, int pointsConceded, int onePoint, int twoPoint, int fourPoint,  int fivePoint, bool pin) : base(team, duration, location, playingSurface, penalties)
    {
        _pointsConceded = pointsConceded;
        _onePoint = onePoint;
        _twoPoint = twoPoint;
        _fourPoint = fourPoint;
        _fivePoint = fivePoint;
        _pin = pin;
        SetPoints();
        SetOutcome();
    }

    public override void SetOutcome()
    {
        if (_pin == true)
        {
            _outcome = Outcome.Won;
        }
        else if (_points > (_pointsConceded + 8))
        {
            _outcome = Outcome.Won;
        }
        else if (_points < (_pointsConceded + 8) && _points > (_pointsConceded - 8))
        {
            _outcome = Outcome.Tied;
        }
        else
        {
            _outcome = Outcome.Lost;
        }
    }

    public void SetPoints()
    {
        _points = _onePoint + _twoPoint*2 + _fourPoint*4 + _fivePoint*5;
        if (_pin == true)
        {
            _points += 6;
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
        Console.WriteLine(_onePoint);
        Console.WriteLine(_twoPoint);
        Console.WriteLine(_fourPoint);
        Console.WriteLine(_fivePoint);
        Console.WriteLine(_pin);
    }
    
    
    

    public override void SaveAttributes(string team) // Save to a text file (updates existing file, otherwise creates new file)
    {
        string _attributes = $"{_outcome}~{_team}~{_duration}~{_location}~{_playingSurface}~{_penalties}~{_points}~{_pointsConceded}~{_onePoint}~{_twoPoint}~{_fourPoint}~{_fivePoint}~{_pin}"; // Serialize attributes

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
                _points = int.Parse(parts[6]);
                _pointsConceded = int.Parse(parts[7]);
                _onePoint = int.Parse(parts[8]);
                _twoPoint = int.Parse(parts[9]);
                _fourPoint = int.Parse(parts[10]);
                _fivePoint = int.Parse(parts[11]);
                _pin = bool.Parse(parts[12]);        
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