public class ChecklistGoal : Goal
{
    private int _timesNeeded;
    private int _timesCompleted;
    private int _bonusPoints;


    public ChecklistGoal() : base()
    {
        SetGoalType("ChecklistGoal");

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
        _timesCompleted = timesCompleted;
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


    public override void AddPoints()
    {
        Game game1 = new Game();
        game1.SetChecklistPoints(_pointValue);
        if (_timesCompleted == _timesNeeded)
        {
            game1.SetChecklistPoints(_bonusPoints);
        }
    }

    // public override void SaveAttributes()
    // {
        // _classAttributes = $"{_name}~{_description}~{_completed}~{_pointValue}~{_bonusPoints}~{_timesCompleted}~{_timesNeeded}";


        // string filename = "myFile.txt";
        // string[] lines = System.IO.File.ReadAllLines(filename);

        // foreach (string line in lines)
        // {
        //     string[] parts = line.Split("~");

        //     _name = parts[0];
        //     _description = parts[1];
        //     _completed = parts[2];
        //     _pointValue = int.Parse(parts[3]);
        //     _bonusPoints = int.Parse(parts[4]);
        //     _timesCompleted = int.Parse(parts[5]);
        //     _timesNeeded = int.Parse(parts[6]);
        // }
    // }

    // public override void LoadAttributes()
    // {
        // // Don't forget to put this at the top, so C# knows where to find the StreamWriter class
        // using System.IO; 

        // ...

        // string fileName = "myFile.txt";

        // using (StreamWriter outputFile = new StreamWriter(filename))
        // {
        //     // You can add text to the file with the WriteLine method
        //     outputFile.WriteLine("This will be the first line in the file.");
            
        //     // You can use the $ and include variables just like with Console.WriteLine
        //     string color = "Blue";
        //     outputFile.WriteLine($"My favorite color is {color}");
        // }
    // }
}