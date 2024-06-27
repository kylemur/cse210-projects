public abstract class Goal
{
    private string _name;
    private string _description;
    private int _pointValue;
    protected bool _completed;


    public Goal()
    {
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _pointValue = int.Parse(Console.ReadLine());
    }


    // public void SetPointValue(int pointValue)
    // {
    //     _pointValue = pointValue;
    // }
    public virtual void SetCompleted()
    {
        _completed = true;
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


    public abstract void AddPoints();
    public virtual void SaveAttributes()
    {
        // _classAttributes = $"{_name}~{_description}~{_completed}~{_pointValue}";


        // string filename = "myFile.txt";
        // string[] lines = System.IO.File.ReadAllLines(filename);

        // foreach (string line in lines)
        // {
        //     string[] parts = line.Split("~");

        //     _name = parts[0];
        //     _description = parts[1];
        //     _completed = parts[2];
        //     _pointValue = parts[3];
        // }
    }
    public virtual void LoadAttributes()
    {
        // // Don't forget to put this at the top, so C# knows where to find the StreamWriter class
        // using System.IO; 

        // ...

        // string fileName = "myFile.txt";

        // using (StreamWriter outputFile = new StreamWriter(filename))
        // {
        //     // You can add text to the file with the WriteLine method
        //     outputFile.WriteLine("This will be the first line in the file.");
            
        //     // You can use the $ and include variables just like with Console.WriteLine
        //     string color = "Blue";
        //     outputFile.WriteLine($"My favorite color is {color}");
        // }
    }
}