public class Comment
{
    private string _commenter;
    private string _contents;

    public Comment(string commenter, string contents)
    {
        _commenter = commenter;
        _contents = contents;
    }

    public void DisplayCommentInformation()
    {
        Console.WriteLine($"{_commenter}: {_contents}");
    }

}

