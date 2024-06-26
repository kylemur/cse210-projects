public abstract class Goal : Game
{
    private string _name;
    private string _description;
    private int _pointValue;
    protected bool _completed;

    public Goal(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void SetPointValue(int pointValue)
    {
        _pointValue = pointValue;
    }
    public int GetPointValue()
    {
        return _pointValue;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public bool GetCompleted()
    {
        return _completed;
    }

    public abstract void SetCompleted();

    // public abstract void AddPoints(int points);
}