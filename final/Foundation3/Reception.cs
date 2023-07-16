public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, TimeSpan time, Address address, string eRsvpEmail) : base(title, description, date, time, address)
    {
        _rsvpEmail = eRsvpEmail;
    }

    public string GetEventDetails()
    {
        return $"{GetFullDetails()}RSVP Email: {_rsvpEmail}";
    }
} 