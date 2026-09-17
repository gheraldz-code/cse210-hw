using System.IO; // C# knows where to find the StreamWriter class

public class Journal
{
    // The C# convention is to start member variables with an underscore _
    public List<Entry> _entries;
    private bool _hasSavedChanges = true;
    public Journal()
    {
        _entries = new List<Entry>();
    }
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        _hasSavedChanges = false;
    }

    public void DisplayAll()
    {
        foreach (Entry item in _entries)
        {
            item.Display();
            Console.WriteLine("");
        }
    }
    public void LoadFromFile(string file)
    {
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry anEntry = new Entry();
            anEntry._date = parts[0];
            anEntry._promptText = parts[1];
            anEntry._entryText = parts[2];
            AddEntry(anEntry);
        }
    }
    public void SaveToFile(string file)
    {
        string filename = file;

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry item in _entries)
            {
                outputFile.WriteLine($"{item._date}|{item._promptText}|{item._entryText}");
            }
        }
        _hasSavedChanges = true;
    }
    public int HasJournalData() //this is a new method
    {
        if (_entries.Count > 0)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
    public bool WasSaved() //this is a new method
    {
        return _hasSavedChanges;
    }
}