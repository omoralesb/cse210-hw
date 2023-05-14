using System.IO;

class Name 
{
    string _namefile = "name.txt";
    string _username = "";
    string[] _nameline;
    public string getName()
    {
        //string userName = Environment.UserName;

        if (!File.Exists("name.txt"))
        {
            Console.Clear();
            Console.WriteLine("What is your name?");
            string username = Console.ReadLine();
            using (StreamWriter namefile = new StreamWriter(_namefile))
            {   
                namefile.WriteLine($"{username}");
                _username = username;
                Console.Clear();
                return _username;
            }
        }
        else
        {    
            Console.Clear();
            _nameline = System.IO.File.ReadAllLines(_namefile);
            foreach (string line in _nameline)
            {
                _username = line;
                
            }
            return _username;
        }
    }
}