class Entry
{
    public List<string> _userEntries = new List<string>();
    public void add_entry_to_list(string prompt, string response)
    {
        
        if (response == "")
        {
            response = "No Entry";
        }
        var userEntry = $"Date: {DateTime.Now.ToShortDateString()} - Prompt: {prompt} \nResponse: {response}\n";
        
        
        //What to do with the info stored in the above format
        _userEntries.Add(userEntry);
        

    }
} 