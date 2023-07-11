public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture() : base("Lecture")
    {

    }

    public void SetLectureDetails(string speaker, int capacity)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void DisplayDetailedMessage()
    {
        Console.WriteLine($"Event name: \"{_eventTitle}\"\nCapacity: {_capacity}\nGuest speaker: {_speaker}\nDescription: \"{_description}\"\nDate: {_date}\nTime: {_time}\nAddress: {_address.DisplayAddress()}");
    }
}