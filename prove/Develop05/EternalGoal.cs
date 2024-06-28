public class EternalGoal : Goal
{
    public EternalGoal() : base()
    {
        SetGoalType("EternalGoal");
        SetCompleted(false);
    }

    public override void SetCompleted(bool isCompleted)
    {
        _isCompleted = false;
    }
    
    // public override void AddPoints()
    // {
    //     Game game1 = new Game();
    //     game1.SetEternalPoints(GetPointValue());
    // }
}