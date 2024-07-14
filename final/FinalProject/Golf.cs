class Golf : SportingEvent
{
    private int _totalStrokes;
    private List<int> _pars = new();
    private List<int> _actuals = new();
    private int _ace;
    private int _condor;
    private int _albatross;
    private int _eagle;
    private int _birdie;
    private int _par;
    private int _bogey;
    private int _twoBogey;
    private int _threeBogey;
    private int _moreBogey;

    public Golf(float duration, string location, string playingSurface, int penalties) : base(duration, location, playingSurface, penalties)
    {

    }

    public void SetPars()
    {
        // for (int i=1, i=18, i++)
        // {
        //     Console.Write($"Hole {i} par: ");
        //     int parOne = int.Parse(Console.ReadLine());
        //     _pars.Add(parOne);
        // }
    }

    public void SetActuals()
    {

    }
    public void SetTotalStrokes()
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