public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool completed) : base(name, description, points, completed)
    {
        //nothing needed here
    }

    public override void SetCompleted()
    {
        
    }
    
}