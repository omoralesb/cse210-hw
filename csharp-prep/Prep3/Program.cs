using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int magicNumber = Convert.ToInt32(Console.ReadLine());
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int userGuess = -1;
        while (userGuess != magicNumber)
        {
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());

            if (userGuess > magicNumber)
            {
                Console.WriteLine("Try lower");
            }    
            if (userGuess < magicNumber)
            {    
                Console.WriteLine("Try higher");
            }
            else 
            {
                Console.Write("Congrats, you guessed it!");
            }       
        }                  
    }
}