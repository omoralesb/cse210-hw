public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _zipCode;

    public Address(string streetAddress, string city, string state, string zipCode)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _zipCode = zipCode;
    }

    public override string ToString()
    {
        return $"{_streetAddress}, {_city}, {_state} {_zipCode}";
    }
} 