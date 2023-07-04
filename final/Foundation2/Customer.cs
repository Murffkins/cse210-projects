// Make sure that all member variables are private and getters, setters, and constructors are created as needed.
public class Customer
{
    // The customer contains a name (string) and an address (another class).
    private string _name;
    private Address address;

    public Customer()
    {
        address = new Address();
    }

    public string GetShippingLabel()
    {
        string shippingLabel = $"{_name}, {address.CompleteAddress}";
        return shippingLabel;
    }

    // The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)
    public bool UsCitizen()
    {
        bool isCitizen = address.IsUsa();
        return isCitizen;
    }


}