public abstract class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    private string _eventType;


    public Event()
    {

    }

    public Event(string eventType)
    {
        _eventType = eventType;
    }
    // Setters
    public void SetEventDetails(string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }


    // #############################################################################################

    // Getters
    public string GetEventTitle()
    {
        return _eventTitle;
    }

    public string GetDescription()
    {
        return _description;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }
    public string GetAddress()
    {
        return _address.DisplayAddress();
    }
    // ############################################################################################

    public void DisplayStandardMessage()
    {
        // Console.WriteLine($"Name of event: {_eventTitle}\n{_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address}");
        Console.WriteLine($"Event name: \"{_eventTitle}\"\nDescription: \"{_description}\"\nDate: {_date}\nTime: {_time}\nAddress: {GetAddress()}");
    }

    public void DisplayShortMessage()
    {
        Console.WriteLine($"Event type: {_eventType}\nTitle of Event: \"{_eventTitle}\"\nEvent date: {_date}");
    }

    public abstract void DisplayDetailedMessage();


}