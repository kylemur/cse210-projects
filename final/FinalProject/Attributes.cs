using System;
using System.IO;
using System.Linq;


class Attributes
{
    private List<SportingEvent> _attributes = new List<SportingEvent>();
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

    // public void Save()
    // {
    //     foreach (SportingEvent se in _attributes)
    //     {
    //         se.SaveAttributes();
    //     }
    // }

    // public void Load()
    // {
    //     string folderPath = "Stats"; 
    //     string[] filePaths = Directory.GetFiles(folderPath);
    //     var fileNames = filePaths.Select(path => Path.GetFileName(path));

    //     foreach (var fileName in fileNames)
    //     {
    //         fileName.ToString();
    //         Console.WriteLine(fileName);
    //         if (fileName == "Stats\\Baseball.txt" || fileName == "Stats/Baseball.txt")
    //         {
    //             string[] lines = File.ReadAllLines($"Stats\\{fileName}"); // Get each line from the file
    //             for (int i = 0; i < lines.Length; i++)
    //             {
    //                 string[] p = lines[i].Split("~");
    //                 Baseball baseball2 = new Baseball();
    //                 baseball2.LoadAttributes($"Stats\\{fileName}");
    //                 _attributes.Add(baseball2);
    //             }
    //         }
    //         else if (fileName == "Stats\\Basketball.txt" || fileName == "Stats/Basketball.txt")
    //         {
    //             string[] lines = File.ReadAllLines(fileName); 
    //             for (int i = 0; i < lines.Length; i++)
    //             {
    //                 string[] p = lines[i].Split("~");
    //                 Basketball basketball2 = new Basketball();
    //                 basketball2.LoadAttributes(fileName);
    //                 _attributes.Add(basketball2);
    //             }
    //         }
    //         else if (fileName == "Stats\\Football.txt" || fileName == "Stats/Football.txt")
    //         {
    //             string[] lines = File.ReadAllLines(fileName); 
    //             for (int i = 0; i < lines.Length; i++)
    //             {
    //                 string[] p = lines[i].Split("~");
    //                 Football football2 = new Football();
    //                 football2.LoadAttributes(fileName);
    //                 _attributes.Add(football2);
    //             }
    //         }
    //         else if (fileName == "Stats\\Golf.txt" || fileName == "Stats/Golf.txt")
    //         {
    //             string[] lines = File.ReadAllLines(fileName); 
    //             for (int i = 0; i < lines.Length; i++)
    //             {
    //                 string[] p = lines[i].Split("~");
    //                 Golf golf2 = new Golf();
    //                 golf2.LoadAttributes(fileName);
    //                 _attributes.Add(golf2);
    //             }
    //         }
    //         else if (fileName == "Stats\\Hockey.txt" || fileName == "Stats/Hockey.txt")
    //         {
    //             string[] lines = File.ReadAllLines(fileName); 
    //             for (int i = 0; i < lines.Length; i++)
    //             {
    //                 string[] p = lines[i].Split("~");
    //                 Hockey hockey2 = new Hockey();
    //                 hockey2.LoadAttributes(fileName);
    //                 _attributes.Add(hockey2);
    //             }
    //         }
    //         else if (fileName == "Stats\\Soccer.txt" || fileName == "Stats/Soccer.txt")
    //         {
    //             string[] lines = File.ReadAllLines(fileName); 
    //             for (int i = 0; i < lines.Length; i++)
    //             {
    //                 string[] p = lines[i].Split("~");
    //                 Soccer soccer2 = new Soccer();
    //                 soccer2.LoadAttributes(fileName);
    //                 _attributes.Add(soccer2);
    //             }
    //         }
    //         else if (fileName == "Stats\\Wrestling.txt" || fileName == "Stats/Wrestling.txt")
    //         {
    //             string[] lines = File.ReadAllLines(fileName); 
    //             for (int i = 0; i < lines.Length; i++)
    //             {
    //                 string[] p = lines[i].Split("~");
    //                 Wrestling wrestling2 = new Wrestling();
    //                 wrestling2.LoadAttributes(fileName);
    //                 _attributes.Add(wrestling2);
    //             }
    //         }
    //     }
    // }

    
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
                    // _attributes.Clear();

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
                            Football football = new Football(parts[1], float.Parse(parts[2]), parts[3], parts[4], int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[8]), int.Parse(parts[9]), int.Parse(parts[10]), int.Parse(parts[11]), int.Parse(parts[12]), int.Parse(parts[13]), int.Parse(parts[14]), int.Parse(parts[15]), int.Parse(parts[16]));
                            _attributes.Add(football);
                        }
                        else if (fileNamePath.Contains("Golf")) 
                        {
                            Golf golf = new Golf(parts[1], float.Parse(parts[2]), parts[3], parts[4], int.Parse(parts[5]));
                            golf.SetPars(parts[7].Split(',').Select(int.Parse).ToList()); // copilot helped me to deserialize a list
                            golf.SetActuals(parts[8].Split(',').Select(int.Parse).ToList());
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

    public void Leaderboard()
    {}
}