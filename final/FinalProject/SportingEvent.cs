abstract class SportingEvent
{
    private List<string> _players = new();

    // private enum _outcome = won, lost, tied, other

    private float _duration;
    private string _location;
    private string _playingSurface;
    private int _penalties;

    public SportingEvent(float duration, string location, string playingSurface, int penalties)
    {

    }

    public void AddPlayer()
    {

    }
    public abstract void SetOutcome();

    public abstract void SaveAttributes();
    public abstract void LoadAttributes();

}