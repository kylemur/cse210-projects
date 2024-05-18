// Shows one entry or all the entries. Adds an entry to _entries list. 
// Saves or downloads all entries. 

using System.Formats.Tar;

public class Journal
{
    // public Entry _entry = new Entry();
    // public List<string> _entries = new List<string>();
    private List<string> _entries;

    public Journal()
    {
        // Initialize the list
        _entries = new List<string>();

        // _entries.Add(_entry);
    }

    // public string _entry;

    // public string _response;
    // _response._response

    // public void AddEntry()
    // {

    // }
    public string _fileName = "";

    public void Display()
    {
        foreach (string e in _entries)
        // foreach (string r in _response)
        {
            Console.WriteLine(e);
        }
    }

    public void Save()
    {
       
        TextWriter tr = new StreamWriter($@"../../../savedEntries/{_fileName}");
        tr.WriteLine($@"../../../savedEntries/{_fileName}");
        
    }

    public void Load()
    {
        TextReader tr = new StreamReader($@"../../../savedEntries/{_fileName}");
        // tr.ReadLine($@"../../../savedEntries/{_fileName}");
        
    }

}