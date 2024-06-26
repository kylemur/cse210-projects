public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description) : base(name, description)
    {
        //nothing needed here
    }

    public override void SetCompleted()
    {
        _completed = true;
    }

    public override void AddPoints()
    {
        _simplePoints += GetPointValue();
    }
}