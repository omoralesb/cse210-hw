class Menu
{
    private string[] _menuChoices = {
    "Start Breathing Activity",
    "Start Reflecting Activity",
    "Start Listing Activity",
    "Quit"
  };

    public int RunMenu()
    {
        Console.Clear();
        Console.WriteLine("Menu Options:");
        for (int i = 0; i < _menuChoices.Length; i++)
        {
            Console.WriteLine($"{i + 1}) {_menuChoices[i]}");
        }

        Console.Write("Select a choice from the menu: ");
        return Convert.ToInt32(Console.ReadLine());
    }
}
