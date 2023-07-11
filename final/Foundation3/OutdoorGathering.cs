public class OutdoorGathering : Event
{
    private string _weather;
    public OutdoorGathering() : base("Outdoor Gathering")
    {

    }

    public void SetOutdoorGatheringDetails(string weather)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }
    public override void DisplayDetailedMessage()
    {
        Console.WriteLine($"Event name: {_eventTitle}\nDescription: \"{_description}\"\nDate: {_date}\nTime: {_time}\nAddress: {_address.DisplayAddress()}\n*** Today is going to be {_weather} so {GetWeatherType()} ***");
    }

    public static string GetWeatherType()
    {
        Random random = new Random();
        int num = random.Next(1, 4);

        switch (num)
        {
            case 1:
                {
                    return "make sure to pack your sunscreen. It's going to be a scorcher.";
                }

            case 2:
                {
                    return "expect rain and hail the size of baseballs.";
                }

            case 3:
                {
                    return "you may want to rethink your outdoor plans because it is going to snow. ";
                }

            case 4:
                {
                    return "get ready for cloudy with a chance of meatballs.";
                }

            default:
                {
                    return "how about that weather?";
                }

        }
    }
}