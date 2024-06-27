public class EternalGoal : Goal
{
    public EternalGoal() : base()
    {
        SetCompleted();
    }

    public override void SetCompleted()
    {
        _completed = false;
    }
    
    public override void AddPoints()
    {
        Game game1 = new Game();
        game1.SetEternalPoints(GetPointValue());
    }
}