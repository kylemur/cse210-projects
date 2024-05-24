// Shows one entry or all the entries. Adds an entry to _entries list. 
// Saves or downloads all entries. 

using System.Formats.Tar;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        // Initialize the list
        _entries = new List<Entry>();
    }


    public void AddEntry(Entry entry1)
    {
        _entries.Add(entry1);
    }

    public void Display()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    string filePath = @"C:\Users\arien\OneDrive\Kyle BYUI\CSE 210\cse210-projects\prove\Develop02\savedEntries.txt";
    public void Load()
    {
        // Read the content from the input file
        string content;
        using (StreamReader reader = new StreamReader(filePath))
        {
            content = reader.ReadToEnd();
        }
        Console.WriteLine(content);
    }
    public void Save()
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            foreach (Entry e in _entries)
            writer.WriteLine($"{e._date} - {e._prompt} \n{e._response}" + "|");
        }
    }
}