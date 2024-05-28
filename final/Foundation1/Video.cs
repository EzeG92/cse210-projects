using System;


class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> comments;

    public Video (string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public string ShowVideoInfo()
    {
        return $"Title: {_title}\nAuthor: {_author}\nLength: {_lengthInSeconds} seconds";
    }

    public List<Comment> GetComments()
    {
        return new List<Comment>(comments);
    }
}