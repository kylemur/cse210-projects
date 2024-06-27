public class SimpleGoal : Goal
{
    public SimpleGoal() : base()
    {
        //nothing needed here
    }


    public override void AddPoints()
    {
        Game game1 = new Game();
        game1.SetSimplePoints(GetPointValue());
    }
}