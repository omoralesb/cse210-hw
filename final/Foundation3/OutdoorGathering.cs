public class OutdoorGathering : Event
{
    private string _weatherStatement;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherStatement) : base(title, description, date, time, address)
    {
        _weatherStatement = weatherStatement;
    }

    public string GetEventDetails()
    {
        return $"{GetFullDetails()}Weather Statement: {_weatherStatement}";
    }
} 