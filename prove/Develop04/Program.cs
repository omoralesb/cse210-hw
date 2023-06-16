// Extra functionality includes a pause animation
// the pause animation uses code to clear out the pause animations when it is done
// by clearing the line in the console moving the cursor around and overwriting the
// line the animation is on.
// Added the ability to the reflection activity to only display a question one time
// untill all questions have been used and then it displays a line about revisiting some questions
// and resets the question list.
// Sorry assignment is late it is because of the dog bite in my hand like I mentioned.

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new();
        Animation a = new();

        const string QUIT_MESSAGE = "Thank you for being mindful exiting now";
        int choice = 0;
        while (choice != 4)
        {
            choice = menu.RunMenu();
            switch (choice)
            {
                case 1:
                    BreathingActivity ba = new();
                    ba.RunBreathe();
                    break;
                case 2:
                    ReflectingActivity ra = new();
                    ra.RunReflecting();
                    break;
                case 3:
                    ListingActivity la = new();
                    la.RunListing();
                    break;
                case 4:
                    Console.WriteLine(QUIT_MESSAGE);
                    a.PauseAnimation(5);
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    menu.RunMenu();
                    break;
            }
        }
    }
}
