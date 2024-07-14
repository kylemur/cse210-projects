class Soccer : SportingEvent
{
    private int _goals;
    private int _goalsConceded;
    private int _shots;
    private int _shotsOnGoal;
    private int _saves;
    private int _yellowCards;
    private int _redCard;

    public Soccer(float duration, string location, string playingSurface, int penalties, int goals, int goalsConceded, int shots, int shotsOnGoal,  int saves, int yellowCards, int redcards) : base(duration, location, playingSurface, penalties)
    {

    }

    public override void SetOutcome()
    {
        
    }

    public override void SaveAttributes()
    {
        
    }
    public override void LoadAttributes()
    {
        
    }

}