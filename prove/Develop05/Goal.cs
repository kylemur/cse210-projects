public abstract class Goal : SaveLoad
{
    private string _name;
    private string _description;
    private int _points = 0;
    private bool _completed;

    public Goal(string name, string description, int points, bool completed)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = completed;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public bool GetCompleted()
    {
        return _completed;
    }

    public abstract void SetCompleted();
    public virtual void AddPoints()
    {

    }
}