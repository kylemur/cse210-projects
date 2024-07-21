using System;
using System.IO;
using System.Linq;


class Attributes
{
    private List<SportingEvent> _attributes = new List<SportingEvent>();

    public Attributes()
    {
        Load();
    }

    public void AddAttributes(SportingEvent objectName)
    {
        _attributes.Add(objectName);
    }

    public void Display(string option)
    {
        Load();
        Console.WriteLine($"option = {option}");
        Console.WriteLine($"_attributes = {_attributes}");

        if (option == "All")
        {
            foreach (SportingEvent se in _attributes)
            {
                se.DisplayAttributes();
            }
        }
        else if (option == "Baseball")
        {
            foreach (Baseball ba in _attributes)
            {
                ba.DisplayAttributes();
            }
        }
        else if (option == "Basketball")
        {
            foreach (Basketball bb in _attributes)
            {
                bb.DisplayAttributes();
            }
        }
        else if (option == "Football")
        {
            foreach (Football fb in _attributes)
            {
                fb.DisplayAttributes();
            }
        }
        else if (option == "Golf")
        {
            foreach (Golf gf in _attributes)
            {
                gf.DisplayAttributes();
            }
        }
        else if (option == "Hockey")
        {
            foreach (Hockey hy in _attributes)
            {
                hy.DisplayAttributes();
            }
        }
        else if (option == "Soccer")
        {
            foreach (Soccer sr in _attributes)
            {
                sr.DisplayAttributes();
            }
        }
        else if (option == "Wrestling")
        {
            foreach (Wrestling wr in _attributes)
            {
                wr.DisplayAttributes();
            }
        }
        else
        {
            Console.WriteLine($"display option = {option}");
        }
    }

    // public void Save()
    // {
    //     foreach (SportingEvent se in _attributes)
    //     {
    //         se.SaveAttributes();
    //     }
    // }

    public void Load()
    {
        string folderPath = "Stats"; 
        string[] filePaths = Directory.GetFiles(folderPath);
        var fileNames = filePaths.Select(path => Path.GetFileName(path));

        foreach (var fileName in fileNames)
        {
            fileName.ToString();
            Console.WriteLine(fileName);
            if (fileName == "Stats\\Baseball.txt" || fileName == "Stats/Baseball.txt")
            {
                string[] lines = File.ReadAllLines($"Stats\\{fileName}"); // Get each line from the file
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] p = lines[i].Split("~");
                    Baseball baseball2 = new Baseball();
                    baseball2.LoadAttributes($"Stats\\{fileName}");
                    _attributes.Add(baseball2);
                }
            }
            else if (fileName == "Stats\\Basketball.txt" || fileName == "Stats/Basketball.txt")
            {
                string[] lines = File.ReadAllLines(fileName); 
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] p = lines[i].Split("~");
                    Basketball basketball2 = new Basketball();
                    basketball2.LoadAttributes(fileName);
                    _attributes.Add(basketball2);
                }
            }
            else if (fileName == "Stats\\Football.txt" || fileName == "Stats/Football.txt")
            {
                string[] lines = File.ReadAllLines(fileName); 
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] p = lines[i].Split("~");
                    Football football2 = new Football();
                    football2.LoadAttributes(fileName);
                    _attributes.Add(football2);
                }
            }
            else if (fileName == "Stats\\Golf.txt" || fileName == "Stats/Golf.txt")
            {
                string[] lines = File.ReadAllLines(fileName); 
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] p = lines[i].Split("~");
                    Golf golf2 = new Golf();
                    golf2.LoadAttributes(fileName);
                    _attributes.Add(golf2);
                }
            }
            else if (fileName == "Stats\\Hockey.txt" || fileName == "Stats/Hockey.txt")
            {
                string[] lines = File.ReadAllLines(fileName); 
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] p = lines[i].Split("~");
                    Hockey hockey2 = new Hockey();
                    hockey2.LoadAttributes(fileName);
                    _attributes.Add(hockey2);
                }
            }
            else if (fileName == "Stats\\Soccer.txt" || fileName == "Stats/Soccer.txt")
            {
                string[] lines = File.ReadAllLines(fileName); 
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] p = lines[i].Split("~");
                    Soccer soccer2 = new Soccer();
                    soccer2.LoadAttributes(fileName);
                    _attributes.Add(soccer2);
                }
            }
            else if (fileName == "Stats\\Wrestling.txt" || fileName == "Stats/Wrestling.txt")
            {
                string[] lines = File.ReadAllLines(fileName); 
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] p = lines[i].Split("~");
                    Wrestling wrestling2 = new Wrestling();
                    wrestling2.LoadAttributes(fileName);
                    _attributes.Add(wrestling2);
                }
            }
        }
    }

    public void Leaderboard()
    {}
}