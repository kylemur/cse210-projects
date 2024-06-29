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
}