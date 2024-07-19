abstract class SportingEvent
{
    public enum Outcome { Won, Lost, Tied }
    protected Outcome _outcome;
    protected string _team;
    protected float _duration;
    protected string _location;
    protected string _playingSurface;
    protected int _penalties;

    public SportingEvent(string team, float duration, string location, string playingSurface, int penalties)
    {
        _team = team;
        _duration = duration;
        _location = location;
        _playingSurface = playingSurface;
        _penalties = penalties;
    }

    
    public abstract void SetOutcome();

    public Outcome GetOutcome()
    {
        return _outcome;
    }

    public virtual void DisplayAttributes()
    {

    }
    public abstract void SaveAttributes(string team);
    public abstract void LoadAttributes(string team);

}