class Comment
{
    private string _commenterName;
    private string _textComment;

    public Comment(string commenterName, string textComment)
    {
        _commenterName = commenterName;
        _textComment = textComment;
    }

    public void SetComment(string commenterName, string textComment)
    {
        _commenterName = commenterName;
        _textComment = textComment;
    }

    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetTextComment()
    {
        return _textComment;
    }
}