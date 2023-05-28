using System;

class Prompt
{
    private static string _userInput;
    public string GetInput()
    {
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
        _userInput = Console.ReadLine();
        
        return _userInput;
    }
}