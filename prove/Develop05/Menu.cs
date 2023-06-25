public class Menu
{


    public int DisplayMenu(int points)
    {
        Console.WriteLine($"You have {points} points.");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");

        int menuChoice = Convert.ToInt32(Console.ReadLine());
        return menuChoice;
    }

    public int CreateMenu()
    {
        Console.Clear();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.WriteLine("  4. Back");
        
        int menuChoice = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        return menuChoice;
    }
}