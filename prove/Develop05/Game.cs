public abstract class Game
{
    private string _classAttributes; 
    private int _totalPoints;
    protected int _simplePoints;
    protected int _eternalPoints;
    protected int _checklistPoints;

    public Game()
    {
        SetTotalPoints();
    }

    protected void SetTotalPoints()
    {
        _totalPoints = _simplePoints + _eternalPoints + _checklistPoints;
    }
    public abstract void AddPoints();




    // protected void SetSimplePoints(int simplePoints)
    // {
    //     _simplePoints += simplePoints;
    // }
    // protected void SetEternalPoints(int eternalPoints)
    // {
    //     _eternalPoints += eternalPoints;
    // }
    // protected void SetChecklistPoints(int checklistPoints)
    // {
    //     _checklistPoints += checklistPoints;
    // }



    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public virtual void Save()
    {
        // _classAttributes = $"{_totalPoints}~{_simplePoints}~{_eternalPoints}~{_checklistPoints}~\n{_name}~{_description}~{_completed}~{_pointValue}";
    }
    public virtual void Load()
    {

    }
}