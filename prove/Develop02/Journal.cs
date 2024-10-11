using System.IO; 
using System.Collections.Generic;

public class Journal
{

    public void saveFile(List<string> _completedEntries, string _filename)
    {
        using (StreamWriter outputfile = new StreamWriter(_filename))
        {
            foreach (string entry in _completedEntries)
            {
            outputfile.WriteLine(entry);
            }
            outputfile.Flush();
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine($"Wrote to: {currentDirectory}\\{_filename}");
        }
    }

    public void loadFile(string _filename, Entry entry)
    {
    string[] lines = System.IO.File.ReadAllLines(_filename);
    foreach (string line in lines)
    {
        entry._completedEntries.Add(line);
        Console.WriteLine(line);
    }
    }
}