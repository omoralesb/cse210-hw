public class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speakerName, int capacity) : base(title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public string GetEventDetails()
    {
        return $"{GetFullDetails()}Speaker: {_speakerName}\nCapacity: {_capacity}";
    }
} 