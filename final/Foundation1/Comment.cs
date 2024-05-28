using System;

class Comment
{

    private string _commentName;

    private string _commentText;


    public Comment (string commentName, string commentText)
    {
        _commentName = commentName;
        _commentText = commentText;
    }

    public string ShowCommentInfo()
    {
        return "Comment by "+_commentName + " : " + _commentText;
    }

}