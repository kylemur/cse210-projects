using System.IO;

public class Game
{
    private string _pointsAttributes;
    // private List<string> _classAttributesList = new();
    private List<Goal> _goalsList = new();
    private int _totalPoints;
    private int _simplePoints;
    private int _eternalPoints;
    private int _checklistPoints;


    public Game()
    {
        SetTotalPoints();
    }


    public void SetTotalPoints()
    {
        _totalPoints = _simplePoints + _eternalPoints + _checklistPoints;
    }
    public void SetSimplePoints(int simplePoints)
    {
        _simplePoints += simplePoints;
    }
    public void SetEternalPoints(int eternalPoints)
    {
        _eternalPoints += eternalPoints;
    }
    public void SetChecklistPoints(int checklistPoints)
    {
        _checklistPoints += checklistPoints;
    }


    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public int GetSimplePoints()
    {
        return _simplePoints;
    }
    public int GetEternalPoints()
    {
        return _eternalPoints;
    }
    public int GetChecklistPoints()
    {
        return _checklistPoints;
    }

    public void AddGoal(Goal goal)
    {
        _goalsList.Add(goal);
    }








    public void Save(string userName)
    {
        _pointsAttributes = $"{_totalPoints}~{_simplePoints}~{_eternalPoints}~{_checklistPoints}";

        string fileName = $"{userName}GoalInfo.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(_pointsAttributes);
            foreach (Goal goal in _goalsList)
            {
                outputFile.WriteLine(goal.Serialize());
            }
        }

        
    }
    public void Load(string userName)
    {
        
        string filename = $"{userName}GoalInfo.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        
        {
            string[] pointsParts = lines[0].Split("~");

            _totalPoints = int.Parse(pointsParts[0]);
            _simplePoints = int.Parse(pointsParts[1]);
            _eternalPoints = int.Parse(pointsParts[2]);
            _checklistPoints = int.Parse(pointsParts[3]);
        }

        for (int i = 1; i < lines.Count(); i++)
        {
            string[] goalsParts = lines[i].Split("~");
            if (goalsParts[0] == "SimpleGoal")
            {
                SimpleGoal simpleGoal1 = new();
                simpleGoal1.SetGoalType(goalsParts[0]);
                simpleGoal1.SetName(goalsParts[1]);
                simpleGoal1.SetDescription(goalsParts[2]);
                simpleGoal1.SetCompleted(Convert.ToBoolean(goalsParts[3]));
                simpleGoal1.SetPointValue(Convert.ToInt16(goalsParts[4]));

                _goalsList.Add(simpleGoal1);

            }
            else if (goalsParts[0] == "EternalGoal")
            {
                EternalGoal eternalGoal1 = new();
                eternalGoal1.SetGoalType(goalsParts[0]);
                eternalGoal1.SetName(goalsParts[1]);
                eternalGoal1.SetDescription(goalsParts[2]);
                eternalGoal1.SetCompleted(Convert.ToBoolean(goalsParts[3]));
                eternalGoal1.SetPointValue(Convert.ToInt16(goalsParts[4]));

                _goalsList.Add(eternalGoal1);
            }
            else if (goalsParts[0] == "ChecklistGoal")
            {
                ChecklistGoal checklistGoal1 = new();
                checklistGoal1.SetGoalType(goalsParts[0]);
                checklistGoal1.SetName(goalsParts[1]);
                checklistGoal1.SetDescription(goalsParts[2]);
                checklistGoal1.SetCompleted(Convert.ToBoolean(goalsParts[3]));
                checklistGoal1.SetPointValue(Convert.ToInt16(goalsParts[4]));
                checklistGoal1.SetBonusPoints(int.Parse(goalsParts[5]));
                checklistGoal1.SetTimesCompleted(int.Parse(goalsParts[6]));
                checklistGoal1.SetTimesNeeded(int.Parse(goalsParts[7]));

                _goalsList.Add(checklistGoal1);
            }

        }
    }
}