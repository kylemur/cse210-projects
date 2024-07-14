class Wrestling : SportingEvent
{
    private int _points;
    private int _pointsConceded;
    private int _onePoint;
    private int _twoPoint;
    private int _fourPoint;
    private int _fivePoint;
    private bool _pin;

    public Wrestling(float duration, string location, string playingSurface, int penalties, int pointsConceded, int onePoint, int twoPoint, int fourPoint,  int fivePoint, bool pin) : base(duration, location, playingSurface, penalties)
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