class Activity
{
    private string _startingMessage;
    private string _endingMessage;
    private string _description;
    private int _activityTime;

    public Activity() { }
    public Activity(string startingMessage, string endingMessage, string description)
    {
        _startingMessage = startingMessage;
        _endingMessage = endingMessage;
        _description = description;
    }

    protected void SetStartingMessage(string startingMessage)
    {
        _startingMessage = startingMessage;
    }

    protected void SetEndingMessage(string endingMessage)
    {
        _endingMessage = endingMessage;
    }

    protected void SetDescriptionMessage(string description)
    {
        _description = description;
    }

    protected string DisplayStartingMessage()
    {
        return _startingMessage;
    }

    protected string DisplayEndingMessage()
    {
        return _endingMessage;
    }

    protected string DisplayDescriptionMessage()
    {
        return _description;
    }

    protected int GetActivityTime()
    {
        return _activityTime;
    }

    protected void SetActivityTimeInMilliseconds()
    {
        Console.Write("\nHow long would you like to do this activity in seconds?(using increments of 10 seconds) ");
        int seconds = Convert.ToInt32(Console.ReadLine());
        int milliseconds = seconds * 1000;
        _activityTime = milliseconds;
    }

    protected void ShowSpinner(int frameTime, int animationTime)
    {
        Animation a = new();
        a.PlaySpinnerAnimation(frameTime, animationTime);
    }

    protected void ShowCountdown(int maxCount)
    {
        Animation a = new();
        a.PlayCountdownAnimation(maxCount);
    }

    protected void ShowPauseAnimation(int pauseTime)
    {
        Animation a = new();
        a.PauseAnimation(pauseTime);
    }

    protected void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"\n{DisplayStartingMessage()}");
        Console.WriteLine($"\n{DisplayDescriptionMessage()}");
        SetActivityTimeInMilliseconds();  // set timer with base _activityTime
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(500, 5000); // play animation for 5 seconds
        Console.WriteLine(); // spacing
    }

    protected void EndActivity()
    {
        Console.WriteLine($"\n{DisplayEndingMessage()}");
        ShowPauseAnimation(5);
        Console.Clear();
    }
}
