public class ChecklistGoal : Goal
{
    private int _timesNeeded;
    private int _timesCompleted;
    private int _bonusPoints;


    public ChecklistGoal() : base()
    {
        SetGoalType("ChecklistGoal");
    }


    public override void Start()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _pointValue = int.Parse(Console.ReadLine());
        
        Console.Write("How many times does this goal need to be completed for a bonus? ");
        _timesNeeded = int.Parse(Console.ReadLine());
        
        Console.Write($"What is the bonus for accomplishing it {_timesNeeded} times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }


    public void SetTimesNeeded(int timesNeeded)
    {
        _timesNeeded = timesNeeded;
    }
    public void SetTimesCompleted(int timesCompleted)
    {
        _timesCompleted += timesCompleted;
    }
    public void SetBonusPoints(int bonusPoints)
    {
        _bonusPoints = bonusPoints;
    }


    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public int GetTimesNeeded()
    {
        return _timesNeeded;
    }
    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }

    
    public override string Serialize()
    {
        return $"{_goalType}~{_name}~{_description}~{_isCompleted}~{_pointValue}~{_bonusPoints}~{_timesCompleted}~{_timesNeeded}";
    }

    public override void Deserialize()
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            _goalType = parts[0];
            _name = parts[1];
            _description = parts[2];
            _isCompleted = Convert.ToBoolean(parts[3]);
            _pointValue = Convert.ToInt16(parts[4]);
            _bonusPoints = int.Parse(parts[5]);
            _timesCompleted = int.Parse(parts[6]);
            _timesNeeded = int.Parse(parts[7]);
        }
    }

    public override string SerializeForList()
    {
        string completed = "[ ]";
        if (_isCompleted == true)
        {
            completed = "[x]";
        }
        return $"{completed} {_name} ({_description}) -- Currently completed: {_timesCompleted}/{_timesNeeded}";
    }
}