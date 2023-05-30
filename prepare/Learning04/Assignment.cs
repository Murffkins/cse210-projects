public class Assignment
{
    private string _studentName = "";
    private string _topic = "";

    public Assignment(string studentName, string topic)
    {
        //  Setters
        _studentName = studentName;
        _topic = topic;
    }

    // Getter
    public string GetStudentName()
    {
        return _studentName;
    }

    // Getter
    public string GetTopic()
    {
        return _topic;
    }
    
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}