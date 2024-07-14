class Basketball : SportingEvent
{
    private int _points;
    private int _pointsConceded;
    private int _shots;
    private int _shotsMade;
    private int _shotPercent;
    private int _threeShots;
    private int _threeShotsMade;
    private int _threePercent;
    private int _freeThrows;
    private int _freeMade;
    private int _freePercent;

    public Basketball(float duration, string location, string playingSurface, int penalties, int points, int pointsConceded, int shots, int shotsMade,  int saves, int threeShots, int threeShotsMade, int freeThrows, int freeMade) : base(duration, location, playingSurface, penalties)
    {

    }

    public void SetShotPercent()
    {

    }
    public void SetThreePercent()
    {

    }
    public void SetFreePercent()
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