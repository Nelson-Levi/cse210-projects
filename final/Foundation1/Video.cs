public class Video 
{
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _commentList;

    public Video(string title, string author, double length)
    {
        _title = title;
        _author = author;
        _length = length;
        _commentList = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
    }

    public int GetCommentAmount()
    {
        int commentAmount =_commentList.Count;
        return commentAmount;
    }

    public void DisplayVideoInformation()
    {
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length}");
        Console.WriteLine($"Number of Comments: {GetCommentAmount()}");
        Console.WriteLine();
    }

    public List<Comment> GetCommentList()
    {
        return _commentList;
    }
}

