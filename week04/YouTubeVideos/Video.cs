class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int GetNumberOfComments()
    {
        int numberOfComments = 0;
        foreach(Comment comment in _comments)
        {
            numberOfComments += 1;
        }
        return numberOfComments;
    }

    public string GetDisplayText()
    {
        string text = "";
        text += $"{_title} by {_author} ({_length} seconds)\n";
        foreach(Comment comment in _comments)
        {
            text += comment.GetDisplayText();
        }
        return text;
    }

    public void AddComment(string name, string text)
    {
        _comments.Add(new Comment(name, text));
    }
}