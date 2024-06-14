public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    protected int _cycles = 0;
    private List<string> _spinner = new List<string>
    {
        "|", "/", "-", "\\"
    };

    public Activity()
    {
        
    }

    protected void ShowStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}. \n");
        Console.WriteLine(_description);
        SpinnerPause(10);
    }
    public void ShowEndMessage()
    {
        Console.WriteLine("Well done!!! ");
        SpinnerPause();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}. ");
        SpinnerPause(5);
    }
    protected void SetActivityName(string name)
    {
        _name = name;
    }
    protected void SetDescription(string description)
    {
        _description = description;
    }

    protected void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }
    
    public void TimerPause(int seconds=5)
    {
        Console.Write(seconds);
        while (seconds > 0)
        {
            seconds -= 1;
            Thread.Sleep(1000);

            Console.Write("\b \b"); // Erase the old timer number
            if (seconds != 0)
            {
                Console.Write(seconds); // Replace it with the new timer number
            }
        }
        Console.WriteLine();
    }
    public void SpinnerPause(int seconds=3)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now <= endTime)
        {
            i = CycleThroughList(_spinner, _cycles);
            Thread.Sleep(250);

            Console.Write("\b \b"); // Erase the old spinner character
            if (DateTime.Now < endTime)
            {
                Console.Write(_spinner[i]); // Replace it with the new spinner character
            }
        }
        Console.WriteLine();
    }



    // I used ChatGPT to help me with CycleThroughList method. It returned: 
    // static void CycleThroughList<T>(List<T> list, int cycles)
    // {
    //     for (int i = 0; i < cycles; i++)
    //     {
    //         int index = i % list.Count;
    //         Console.WriteLine(list[index]);
    //     }
    // }
    protected int CycleThroughList<T>(List<T> list, int cycles)
    {
        int index = 0;
        for (int i = 0; i < cycles; i++)
        {
            index = i % list.Count;
        }
        _cycles += 1;
        return index;
    }
}