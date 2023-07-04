public class Video
{
    private string _title;
    private string _author;
    private int _lengthOfVideo;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthOfVideo)
    {
        _title = title;
        _author = author;
        _lengthOfVideo = lengthOfVideo;
        _comments = new List<Comment>();
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetVideoLength()
    {
        return _lengthOfVideo;
    }

    public void CreateCommentList(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            string commenterName = comment.GetCommenterName();
            string commentText = comment.GetCommentText();

            Console.WriteLine($"{commenterName}:\n{commentText}");
        }
    }

    public int NumOfComments()
    {
        return _comments.Count;
    }

    public void DisplayVideoData()
    {
        string title = GetTitle();
        string author = GetAuthor();
        int videoLength = GetVideoLength();
        int numOfComments = NumOfComments();
        Console.WriteLine($"{title} by {author} ({videoLength} seconds)");
        Console.WriteLine($"There are {numOfComments} comments");
        DisplayComments();
        Console.WriteLine();
    }
}
