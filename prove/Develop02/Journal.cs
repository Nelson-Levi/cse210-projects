using System.IO;
using System.Collections.Generic;
using System.Collections;

public class Journal
{

    public void SaveFile(List<string> _completedEntries, string _filename)
    {
        using (StreamWriter outputfile = new StreamWriter(_filename))
        {
            // Write every entry in the list to the desired file.
            foreach (string entry in _completedEntries)
            {
                outputfile.WriteLine(entry);
            }
            // Clear out all the buffered data to prevent errors.
            outputfile.Flush();
            // Display file location.
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine($"Wrote to: {currentDirectory}\\{_filename}");
        }
    }

    public void LoadFile(string _filename, Entry entry)
    {
        if (File.Exists(_filename))
        {
            string[] lines = System.IO.File.ReadAllLines(_filename);
            foreach (string line in lines)
            {
                // Add the entries in the loaded file to the _completedEntries list, then display them.
                entry._completedEntries.Add(line);
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine($"{_filename} does not exist.");
        }
    }
}