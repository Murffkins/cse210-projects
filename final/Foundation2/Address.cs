// Make sure that all member variables are private and getters, setters, and constructors are created as needed.
public class Address
{
    // The address contains a string for the street address, the city, state/province, and country.
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    private bool _isUsa = false;


    public Address()
    {
    }

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        //  Setters
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    // Getter
    public string GetAddress()
    {
        return $"{_streetAddress}, {_city}, {_stateProvince}, {_country}";
    }

    // The address should have a method that can return whether it is in the USA or not.
    public bool IsUsa()
    {
        if (_country == "USA")
        {
            _isUsa = true;
        }
        return _isUsa;
    }

    // The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)
    public string CompleteAddress()
    {
        string address = $"{_streetAddress}\n{_city}, {_stateProvince}  {_country}";
        return address;
    }
}