public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city.ToUpper();
        _state = state.ToUpper();
        if (country.ToUpper() == "USA")
        {
            _country = "UNITED STATES";
        }
        else
        {
            _country = country.ToUpper();
        }
    }

    public bool IsInUSA()
    {
        return _country == "UNITED STATES";
    }

    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}