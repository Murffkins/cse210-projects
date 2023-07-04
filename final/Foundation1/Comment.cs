public class Comment
{
    private string _commenterName;
    private string _comment_text;

    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _comment_text = commentText;
    }

    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetCommentText()
    {
        return _comment_text;
    }
}