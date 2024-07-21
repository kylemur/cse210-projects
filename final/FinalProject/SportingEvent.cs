abstract class SportingEvent
{
    protected string _class = "SportingEvent";
    public enum Outcome { Won, Lost, Tied }
    protected Outcome _outcome = Outcome.Tied;
    protected string _team = "";
    protected float _duration = 0;
    protected string _location = "";
    protected string _playingSurface = "";
    protected int _penalties = 0;

    public SportingEvent(string team="", float duration=0.0f, string location="", string playingSurface="", int penalties=0)
    {
        _team = team;
        _duration = duration;
        _location = location;
        _playingSurface = playingSurface;
        _penalties = penalties;
    }

    public string GetClass()
    {
        return _class;
    }
    public string GetTeam()
    {
        return _team;
    }
    
    public abstract void SetOutcome();

    public Outcome GetOutcome()
    {
        return _outcome;
    }

    public abstract void DisplayAttributes();
    public abstract void SaveAttributes();
    public abstract void LoadAttributes(string filename);

}