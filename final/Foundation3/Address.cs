public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private int _zipcode;

    public Address(string streetAddress, string city, string state, int zipcode)
    {
        //  Setters
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _zipcode = zipcode;
    }

    // public string GetStreet()
    // {
    //     return _streetAddress;
    // }
    // public string GetCity()
    // {
    //     return _city;
    // }
    // public string GetState()
    // {
    //     return _state;
    // }
    // public int GetZip()
    // {
    //     return _zipcode;
    // }

    public string DisplayAddress()
    {
        string address = $"{_streetAddress}\n{_city}, {_state}  {_zipcode}";
        return address;
    }
}