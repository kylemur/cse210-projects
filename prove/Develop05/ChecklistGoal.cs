public class ChecklistGoal : Goal
{
    private int _timesNeeded;
    private int _timesCompleted;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int timesNeeded, int timesCompleted, int bonusPoints) : base(name, description)
    {
        _timesNeeded = timesNeeded;
        _timesCompleted = timesCompleted;
        _bonusPoints = bonusPoints;
    }

    public int GetTimesNeeded()
    {
        return _timesNeeded;
    }
    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }

    public override void SetCompleted()
    {
        
    }
    
    public override void AddPoints()
    {
        _checklistPoints += GetPointValue();
        if (_timesCompleted == _timesNeeded)
        {
            _checklistPoints += _bonusPoints;
        }
    }

    public override void Save()
    {
        // _classAttributes = $"{_totalPoints}~{_simplePoints}~{_eternalPoints}~{_checklistPoints}~\n{_name}~{_description}~{_completed}~{_pointValue}~{_bonusPoints}~{_timesCompleted}~{_timesNeeded}";
    }
    public override void Load()
    {
        //base.LoadAttributes();
    }
}