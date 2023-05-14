
class PromptGenerator 
{
    public List<string> _promptList = new List<string>()
        {
            "What was the best thing that happened to you today?",
            "Did you read your scriptures today?",
            "What blessings or opportunities did you see today?",
            "What was something that made you laugh today?",
            "What did you learn today that you didn't know yesterday?",
            "What gave you stress today?",
            "What is something selfless you did for someone else today?",
            "How can you make tomorrow even better than today?"
        };
    public List<string> _usedList = new List<string>(); 
    public System.Random random = new Random();
    public string GeneratePrompt()
    {
        if (_usedList.Count >= _promptList.Count())
        {
            _usedList.Clear();
        }
        var r = random.Next(_promptList.Count);
        var randomEntry = _promptList[r];

        while (_usedList.Contains(r.ToString()))
        {
            r = random.Next(_promptList.Count);
            randomEntry = _promptList[r];
        }
        string prompt = randomEntry;
        
        _usedList.Add(r.ToString());
        return randomEntry;
    }
}