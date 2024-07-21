class Attributes
{
    private List<SportingEvent> _attributes = new();

    public Attributes()
    {
        Load();
    }

    public void Display()
    {
        foreach (SportingEvent se in _attributes)
        {
            se.DisplayAttributes();
        }
    }

    public void Save()
    {
        foreach (SportingEvent se in _attributes)
        {
            se.SaveAttributes();
        }
    }

    public void Load()
    {
        foreach (SportingEvent se in _attributes)
        {
            se.LoadAttributes();
        }
    }

    // public void Load(SportingEvent classType)
    // {
    //     foreach (SportingEvent se in _attributes)
    //     {
    //         se.LoadAttributes();
    //     }
    // }
}