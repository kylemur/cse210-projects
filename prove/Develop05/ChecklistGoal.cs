public class ChecklistGoal : Goal
{
    private int _timesNeeded;
    private int _timesCompleted;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, bool completed, int timesNeeded, int timesCompleted, int bonusPoints) : base(name, description, points, completed)
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
        //base.AddPoints();
    }

    public override void SaveAttributes()
    {
        //base.SaveAttributes();
    }
    public override void LoadAttributes()
    {
        //base.LoadAttributes();
    }
}