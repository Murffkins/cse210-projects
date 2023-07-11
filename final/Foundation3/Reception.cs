public class Reception : Event
{
    private string _email;
    private bool _rsvp;
    private bool _register;

    public Reception() : base("Reception")
    {

    }
    public void SetReceptionDetails(string email, bool rsvp, bool register)
    {
        _email = email;
        _rsvp = rsvp;
        _register = register;
    }

    public bool GetRSVP()
    {
        return _rsvp;
    }

    public override void DisplayDetailedMessage()
    {
        Console.WriteLine($"Event name: {_eventTitle}\nDescription: \"{_description}\"\nDate: {_date}\nTime: {_time}\nAddress: {_address.DisplayAddress()}\n*** Send your RSVP to murffkins@someemail.com ***");
    }
}