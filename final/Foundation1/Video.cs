class Video
{
    // Private attributes
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment>();

    // Constructor to initialize Video object
    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    // Method to add comments to the video
    public void AddComment(string commenterName, string commentText)
    {
        Comment comment = new Comment(commenterName, commentText);
        _comments.Add(comment);
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to generate a string representation of the video
    public string GetVideoInfo()
    {
        string videoInfo = $"Title: {_title}\nAuthor: {_author}\nLength: {_lengthInSeconds} seconds\nNumber of Comments: {GetNumberOfComments()}\nComments:\n";

        foreach (var comment in _comments)
        {
            videoInfo += $"{comment.GetCommentInfo()}\n";
        }

        return videoInfo;
    }
}