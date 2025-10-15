using System.IO;

public class Journal
{
    List<Entry> _journal = new List<Entry>();

    // Display Current Entries
    public void DisplayListOfEntries()
    {
        foreach (Entry entry in _journal)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    // Add Entry to Journal
    public void AddEntry(Entry entry)
    {
        _journal.Add(entry);
    }

    // Save Journal as CSV File
    public void SaveToFile()
    {
        Console.WriteLine("Creating File...");
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        Console.WriteLine($"\nSaved file as \"{filename}\"!\n");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _journal)
            {
                outputFile.WriteLine($"|{e._entry}|\n");
            }
        }
    }
    
    // Pull Existing Journal File
    public List<Entry> ReadFromFile()
    {
        List<Entry> entries = new List<Entry>();
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        Console.WriteLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        return entries;
    }
}