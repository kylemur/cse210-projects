public class Game
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


    public void SetTotalPoints()
    {
        _totalPoints = _simplePoints + _eternalPoints + _checklistPoints;
    }
    public void SetSimplePoints(int simplePoints)
    {
        _simplePoints += simplePoints;
    }
    public void SetEternalPoints(int eternalPoints)
    {
        _eternalPoints += eternalPoints;
    }
    public void SetChecklistPoints(int checklistPoints)
    {
        _checklistPoints += checklistPoints;
    }


    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public int GetSimplePoints()
    {
        return _simplePoints;
    }
    public int GetEternalPoints()
    {
        return _eternalPoints;
    }
    public int GetChecklistPoints()
    {
        return _checklistPoints;
    }


    public void SavePoints()
    {
        // _classAttributes = $"{_totalPoints}~{_simplePoints}~{_eternalPoints}~{_checklistPoints}";


        // string filename = "myFile.txt";
        // string[] lines = System.IO.File.ReadAllLines(filename);

        // foreach (string line in lines)
        // {
        //     string[] parts = line.Split("~");

        //     _totalPoints = int.Parse(parts[0]);
        //     _simplePoints = int.Parse(parts[1]);
        //     _eternalPoints = int.Parse(parts[2]);
        //     _checklistPoints = int.Parse(parts[3]);
        // }
    }
    public void LoadPoints()
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