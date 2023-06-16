class Animation
{
    private char[] _spinnerFrames = { '|', '/', '-', '\\', '|', '/', '-', '\\' };

    public Animation()
    {
    }


    public void PauseAnimation(int pauseTime)
    {
        for (int i = 0; i < pauseTime; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        int currentCursorLine = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.BufferWidth));
        Console.SetCursorPosition(0, currentCursorLine);
    }

    public void PlayCountdownAnimation(int maxCount, int frameTime = 1000)
    {
        for (int i = maxCount; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(frameTime);
            Console.Write("\b \b");
        }
    }

    public void PlaySpinnerAnimation(int frameTime, int animationTime)
    {

        DateTime start = DateTime.Now;
        DateTime end = start.AddMilliseconds(animationTime);

        while (DateTime.Now < end)
        {
            for (int i = 0; i < _spinnerFrames.Length; i++)
            {
                if (i < _spinnerFrames.Length)
                {
                    Console.Write(_spinnerFrames[i]);
                    Thread.Sleep(frameTime);
                    Console.Write("\b \b");
                }
                else
                {
                    i = 0;
                    Console.Write(_spinnerFrames[i]);
                    Thread.Sleep(frameTime);
                    Console.Write("\b \b");
                }
            }
        }
    }
}
