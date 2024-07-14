class Baseball : SportingEvent
{
    private int _runs;
    private int _runsConceded;
    private int _foulBalls;
    private int _strikes;
    private int _singles;
    private int _doubles;
    private int _triples;
    private int _homeRuns;

    public Baseball(float duration, string location, string playingSurface, int penalties, int runs, int runsConceded, int foulBalls, int strikes,  int singles, int doubles, int triples, int homeRuns) : base(duration, location, playingSurface, penalties)
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