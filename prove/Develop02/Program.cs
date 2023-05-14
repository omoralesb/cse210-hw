using System;

class Program 
{   
    static string _userInput;

    public List<string> entries = new List<string>();
    static void Main(string[] args)
    {
        var newPrompt = new PromptGenerator();
        var entry = new Entry();
        var journal = new Journal();
        var name = new Name();


        var _username = name.getName();
        
        
        while (_userInput != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write($"What would you like to do, {char.ToUpper(_username[0]) + _username.Substring(1)}?: ");
            _userInput = Console.ReadLine();
            Console.WriteLine();

            if (_userInput == "1")
            {
                var prompt = newPrompt.GeneratePrompt();
                Console.WriteLine($"{prompt}");
                Console.Write($"Entry: ");
                var _userEntry = Console.ReadLine();

                entry.add_entry_to_list(prompt, _userEntry);
                
            } 
            else if (_userInput == "2")
            {
                foreach (string line in entry._userEntries)
                {
                    Console.WriteLine(line);
                }
 
            } 
            else if (_userInput == "3")
            {
                //LOAD JOURNAL FILE HERE
                Console.Write("What is the name of the file: ");
                var filename = Console.ReadLine();
                journal.loadPrompt(filename);
                List<string> entries = journal._loadedList;
                entry._userEntries = journal._loadedList;

            } 
            else if (_userInput == "4")
            {
                List<string> entries = entry._userEntries;
                if (entries.Count == 0)
                {
                    Console.WriteLine("Please make an entry first.");
                }
                else
                {
                    Console.WriteLine("What would you like to name this file? ");
                    string filename = Console.ReadLine();
                
                    journal.savePrompt(entries, filename);
                }
                

            } 
            else if (_userInput == "5")
            {
            
            }
            else
            {
                
                Console.WriteLine("Please make a valid selection. (1 - 5)\n");
            }
        }
        //Print Thank you
        Console.WriteLine("Thanks for taking time to write in your journal.");
    }
}