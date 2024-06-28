public class SimpleGoal : Goal
{
    public SimpleGoal() : base()
    {
        SetGoalType("SimpleGoal");
    }


    public override void AddPoints()
    {
        Game game1 = new Game();
        game1.SetSimplePoints(GetPointValue());
    }
}