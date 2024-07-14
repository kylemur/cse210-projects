class Football : SportingEvent
{
    private int _points;
    private int _pointsConceded;
    private int _touchdowns;
    private int _fieldGoals;
    private int _PATs;
    private int _twoPt;
    private int _otherPoints;
    private int _yardsO;
    private int _yardsD;
    private int _trunovers;

    public Football(float duration, string location, string playingSurface, int penalties, int pointsConceded, int touchdowns, int fieldGoals,  int PATs, int twoPt, int otherPoints, int yardsO, int yardsD, int turnovers) : base(duration, location, playingSurface, penalties)
    {

    }

    public void SetPoints()
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