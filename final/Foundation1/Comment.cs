using System;
using System.Collections.Generic;

// Comment class to represent individual comments
class Comment
{
    // Private attributes
    private string _commenterName;
    private string _commentText;

    // Constructor to initialize Comment object
    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    // Method to generate a string representation of the comment
    public string GetCommentInfo()
    {
        return $"{_commenterName}: {_commentText}";
    }
}