class Attributes
{
    private List<SportingEvent> _attributes = new();

    public void Display(SportingEvent classType)
    {
        foreach (SportingEvent se in _attributes)
        {
            se.DisplayAttributes();
        }
    }

    public void Save(SportingEvent classType)
    {
        foreach (SportingEvent se in _attributes)
        {
            se.SaveAttributes();
        }
    }

    public void Load(SportingEvent classType)
    {
        foreach (SportingEvent se in _attributes)
        {
            se.LoadAttributes();
        }
    }
}