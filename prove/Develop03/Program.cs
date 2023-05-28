using System;

class Program
{
    //Set program as active bool
    private static bool _active = true;
    private static string _fullScript;

    //Start main class
    static void Main(string[] args)
    {
        //Add instances of classes & clear the console
        Scripture s = new Scripture();
        Update u = new Update();
        Prompt p = new Prompt();
        Console.Clear(); 
        
        //Get full scripture (Reference and text) in format "{_scriptReference}. {_scriptText}"
        _fullScript = s.GetScripture(); 
        //Strip the DOT and print the scripture for the first time
        Console.WriteLine(_fullScript.Replace(".", string.Empty));

        //Main While loop
        while (_active)
        {
            //Get user input
            string userInput = p.GetInput();
            //Clear the screen after getting the user input and prepare for updated scripture or quit
            Console.Clear();

            //Check their input
            if (userInput == "")
            {
                if (u.UpdateScripture(_fullScript) == "COMPLETED")
                {
                    _active = false;
                }
                else
                {
                    //Update the scripture and return it to the _fullScript variable
                    _fullScript = u.UpdateScripture(_fullScript);
                    //Print the newly updated scripture text with reference
                    Console.WriteLine(_fullScript.Replace(".", string.Empty));
                }
            }
            else if (userInput == "quit")
            {
                _active = false;
            }
            else
            {
                //Rewrite the scripture if an invalid key is entered with a message 
                //telling the user to input a valid key
                Console.WriteLine(_fullScript.Replace(".", string.Empty));
                Console.WriteLine("Please enter a valid input.");
            }
        }
    }
}