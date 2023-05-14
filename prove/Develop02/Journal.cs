using System.IO;
class Journal
{   
    public List<string> _loadedList = new List<string>();
    string[] _fileLines;
    public void savePrompt(List<string> journalEntries, string fileName)
    {
        
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {   
            // You can use the $ and include variables just like with Console.WriteLine
            foreach (string item in journalEntries)
            {
                outputFile.WriteLine($"{item}");
            }
                
        }

        Console.WriteLine($"File saved as {fileName}");
    }
        
        
    public void loadPrompt(string filename)
    {
        try 
        {
            _fileLines = System.IO.File.ReadAllLines(filename);

            foreach (string line in _fileLines)
            {
                _loadedList.Add(line);
                //Console.WriteLine(line);
            }
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("Please enter a valid file name.");
        }
    }
} 