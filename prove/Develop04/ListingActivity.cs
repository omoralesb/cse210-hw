using System.Diagnostics;

class ListingActivity : Activity
{
    private List<string> _listQuestions = new();
    private int _countListings;

    public ListingActivity()
    {
        _countListings = 0;
        string[] listQuestionsArr = {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
  };
        _listQuestions.AddRange(listQuestionsArr);

        SetStartingMessage("Welcome to the Listing Activity");
        SetDescriptionMessage("This activity will help you reflect on good things in your life by having you list as many things as you can in a certain time limit.");
    }

    public string GetRandomListQuestion()
    {
        Random rand = new();
        int randNum = rand.Next(_listQuestions.Count);
        return _listQuestions[randNum];
    }

    public void StartListing()
    {
        Console.WriteLine("List as many responses as you can to the following prompt: \n");
        Console.WriteLine($"--- {GetRandomListQuestion()} ---\n");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine("Type something in and press ENTER after each entry.");
    }

    public void Listing()
    {
        Stopwatch sw = new();
        sw.Start();
        while (sw.Elapsed.TotalMilliseconds < GetActivityTime())
        {
            Console.Write("> ");
            Console.ReadLine();
            _countListings++;
        }
        sw.Stop();
    }

    public void RunListing()
    {
        StartActivity();
        StartListing();
        Listing();
        SetEndingMessage($"Congrats you were able to list {_countListings} items in {GetActivityTime() / 1000} seconds thats not so bad is it?");
        EndActivity();
    }
}
