public class EternalGoal : Goal
{
    public EternalGoal(string name, string description) : base(name, description)
    {
        SetCompleted();
    }

    public override void SetCompleted()
    {
        _completed = false;
    }
    
    public override void AddPoints()
    {
        _eternalPoints += GetPointValue();
    }
}