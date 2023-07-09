// Make sure that all member variables are private and getters, setters, and constructors are created as needed.
public class Customer
{
    // The customer contains a name (string) and an address (another class).
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        return _address.DisplayCompleteAddress();
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"Customer: {_name}\nShipping Address:\n{_address.DisplayCompleteAddress()}";
        return shippingLabel;

    }

    // The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
    public bool UsCitizen()
    {
        bool isCitizen = _address.IsUsa();
        return isCitizen;
    }

    public int GetShipping()
    {
        return UsCitizen() ? 5 : 35;
    }


}