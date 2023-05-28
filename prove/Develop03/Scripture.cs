using System;

class Scripture
{
    private string _scriptReference;
    private string _scriptText;
    private string _fullScripture;
    private Dictionary<string, string> _scriptureDict = new Dictionary<string, string>()
    {
        {"Psalm 145:9", "The Lord is good to all"},
        {"Galatians 6:2" , "For every man shall bear his own burden"},
        {"Philippians 4:13" , "I can do everything through Him who gives me strength"}
    };


    public string GetScripture()
    {
        Random rand = new Random();
        int randNum = rand.Next(0, _scriptureDict.Count);
        _scriptReference = $"{_scriptureDict.ElementAt(randNum).Key}";
        _scriptText = $"{_scriptureDict.ElementAt(randNum).Value}";
        _fullScripture = $"{_scriptReference}. {_scriptText}";
        return _fullScripture;
    }


}