using System;
using System.IO;
using System.Linq;
using System.Text;


class Attributes
{
    private List<SportingEvent> _attributes = new List<SportingEvent>();
    private List<SportingEvent> _winners = new List<SportingEvent>();
    private List<string> _winTeams = new();
    private List<string> files =
        [
            "Baseball.txt",
            "Basketball.txt",
            "Football.txt",
            "Golf.txt",
            "Hockey.txt",
            "Soccer.txt",
            "Wrestling.txt",
        ];


    public Attributes()
    {
        Load();
    }



    public int TotalAttributes()
    {
        return _attributes.Count();
    }

    public void Winners()
    {
        foreach (SportingEvent sportingE in _attributes)
        {
            if (sportingE.GetOutcome() == SportingEvent.Outcome.Won)
            {
                Console.WriteLine(sportingE.GetTeam());
            }
        }
    }

    public void AddAttributes(SportingEvent objectName)
    {
        _attributes.Add(objectName);
    }

    public void Display(string option)
    {
        Console.WriteLine();
        Load();
        Console.WriteLine();

        if (option == "All")
        {
            foreach (SportingEvent se in _attributes)
            {
                se.DisplayAttributes();
                Console.WriteLine();
            }
        }
        else if (option == "Baseball")
        {
            foreach (Baseball ba in _attributes.OfType<Baseball>())
            {
                ba.DisplayAttributes();
                Console.WriteLine();
            }
        }
        else if (option == "Basketball")
        {
            foreach (Basketball bb in _attributes.OfType<Basketball>())
            {
                bb.DisplayAttributes();
                Console.WriteLine();
            }
        }
        else if (option == "Football")
        {
            foreach (Football fb in _attributes.OfType<Football>())
            {
                fb.DisplayAttributes();
                Console.WriteLine();
            }
        }
        else if (option == "Golf")
        {
            foreach (Golf gf in _attributes.OfType<Golf>())
            {
                gf.DisplayAttributes();
                Console.WriteLine();
            }
        }
        else if (option == "Hockey")
        {
            foreach (Hockey hy in _attributes.OfType<Hockey>())
            {
                hy.DisplayAttributes();
                Console.WriteLine();
            }
        }
        else if (option == "Soccer")
        {
            foreach (Soccer sr in _attributes.OfType<Soccer>())
            {
                sr.DisplayAttributes();
                Console.WriteLine();
            }
        }
        else if (option == "Wrestling")
        {
            foreach (Wrestling wr in _attributes.OfType<Wrestling>())
            {
                wr.DisplayAttributes();
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine($"display option = {option}");
        }
        Console.WriteLine();
    }

    
    public void Load()
    {
        _attributes.Clear();
        foreach (string file in files)
        {
            // Use Path.Combine for better path handling
            string fileNamePath = Path.Combine("Stats", $"{file}");

            // Check if the file exists before attempting to read
            if (File.Exists(fileNamePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(fileNamePath); // Get each line from the file

                    for (int i = 0; i < lines.Count(); i++)
                    {
                        string[] parts = lines[i].Split("~");
                        if (fileNamePath.Contains("Baseball")) // Get class type and create a new object with the info
                        {
                            Baseball baseball = new Baseball(parts[1], float.Parse(parts[2]), parts[3], parts[4], int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]), int.Parse(parts[8]), int.Parse(parts[9]), int.Parse(parts[10]), int.Parse(parts[11]), int.Parse(parts[12]), int.Parse(parts[13]));
                            _attributes.Add(baseball);
                        }
                        else if (fileNamePath.Contains("Basketball")) 
                        {
                            Basketball basketball = new Basketball(parts[1], float.Parse(parts[2]), parts[3], parts[4], int.Parse(parts[5]), int.Parse(parts[7]), int.Parse(parts[8]), int.Parse(parts[9]), int.Parse(parts[11]), int.Parse(parts[12]), int.Parse(parts[14]), int.Parse(parts[15]));
                            _attributes.Add(basketball);
                        }
                        else if (fileNamePath.Contains("Football")) 
                        {
                            Football football = new Football(parts[0], float.Parse(parts[1]), parts[2], parts[3], int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]), int.Parse(parts[8]), int.Parse(parts[9]), int.Parse(parts[10]), int.Parse(parts[11]), int.Parse(parts[12]), int.Parse(parts[13]), int.Parse(parts[14]));
                            _attributes.Add(football);
                        }
                        else if (fileNamePath.Contains("Golf")) 
                        {
                            Golf golf = new Golf(parts[1], float.Parse(parts[2]), parts[3], parts[4], int.Parse(parts[5]));
                            golf.PutOutcome(parts[0]);
                            golf.SetPars(parts[6]); 
                            golf.SetActuals(parts[7]);
                            golf.SetTotalStrokes();
                            golf.SetNames();
                            _attributes.Add(golf);
                        }
                        else if (fileNamePath.Contains("Hockey")) 
                        {
                            Hockey hockey = new Hockey(parts[1], float.Parse(parts[2]), parts[3], parts[4], int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]), int.Parse(parts[8]), int.Parse(parts[9]), int.Parse(parts[10]), int.Parse(parts[11]));
                            _attributes.Add(hockey);
                        }
                        else if (fileNamePath.Contains("Soccer")) 
                        {
                            Soccer soccer = new Soccer(parts[1], float.Parse(parts[2]), parts[3], parts[4], int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]), int.Parse(parts[8]), int.Parse(parts[9]), int.Parse(parts[10]), int.Parse(parts[11]), int.Parse(parts[12]));
                            _attributes.Add(soccer);
                        }
                        else if (fileNamePath.Contains("Wrestling")) 
                        {
                            Wrestling wrestling = new Wrestling(parts[1], float.Parse(parts[2]), parts[3], parts[4], int.Parse(parts[5]), int.Parse(parts[7]), int.Parse(parts[8]), int.Parse(parts[9]), int.Parse(parts[10]), int.Parse(parts[11]), bool.Parse(parts[12]), bool.Parse(parts[13]));
                            _attributes.Add(wrestling);
                        }
                    }
                }
                catch (IOException ex)
                {
                    // Handle potential IO exceptions (e.g., file is being used by another process)
                    Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"{file} does not exist.");
            }
        }
    }

    public string GetWinnersByFrequency()
    {
        _winTeams.Clear();
        foreach (SportingEvent sportingE in _attributes)
        {
            if (sportingE.GetOutcome() == SportingEvent.Outcome.Won)
            {
                _winTeams.Add($"-{sportingE.GetClass()}- {sportingE.GetTeam()}");
            }
        }

        if (_winTeams.Count == 0)
        {
            return "--There are no instances of a win.--";
        }

        Dictionary<string, int> countMap = new Dictionary<string, int>(); // copilot helped with the rest if this method
        foreach (string winTeam in _winTeams)
        {
            if (countMap.ContainsKey(winTeam))
            {
                countMap[winTeam]++;
            }
            else
            {
                countMap[winTeam] = 1;
            }
        }

        // Sort the dictionary by value (win count) in descending order
        var sortedWinners = countMap.OrderByDescending(x => x.Value);

        StringBuilder result = new StringBuilder();
        foreach (var winTeam in sortedWinners)
        {
            result.AppendLine($"{winTeam.Key} ({winTeam.Value})");
        }

        return result.ToString();
    }
}