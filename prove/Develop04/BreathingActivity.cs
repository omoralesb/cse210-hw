using System.Diagnostics;

class BreathingActivity : Activity
{

    public BreathingActivity()
    {
        SetStartingMessage("Welcome to the Breathing Activity");
        SetEndingMessage("You completed your breathing time. Well Done!");
        SetDescriptionMessage("This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing");

    }

    public void BreatheInOut()
    {
        // the timer seems to not end till full cycle
        // of the activity has finished not sure at the
        // moment how to fix that and its probably a good
        // idea to let the user finish the activity or they may
        // get stuck holding their breath as nothing told them
        // to breath out and I don't want anyone passing out
        Stopwatch sw = new();
        sw.Start();
        while (sw.Elapsed.TotalMilliseconds < GetActivityTime())
        {
            BreatheIn();
            BreatheOut();
        }
        sw.Stop();
    }

    public void BreatheIn()
    {
        // display breathe in for 4 seconds
        // with countdown animation
        Console.Write("Breathe In...");
        ShowCountdown(4);
        Console.WriteLine(); // spacing
    }

    public void BreatheOut()
    {
        // display breathe out for 6 seconds
        // with countdown animation
        Console.Write("Now breathe out...");
        ShowCountdown(6);
        Console.WriteLine("\n"); // spacing
    }

    public void RunBreathe()
    {
        StartActivity();
        BreatheInOut();
        EndActivity();
    }
}
