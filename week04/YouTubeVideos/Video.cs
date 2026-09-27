using Microsoft.Win32.SafeHandles;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment aComment)
    {
        _comments.Add(aComment);
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    public int QuantityOfComments()
    {
        return _comments.Count;
    }

    public string GetComment()
    {
        string result = "";
        if (QuantityOfComments() > 1)
        {
            if (QuantityOfComments() == 1)
            {
                result = "Comment about this video:";
            }
            else
            {
                result = "Comments about this video:";
            }
            foreach (Comment item in _comments)
            {
                result = result + "\n" + item.GetCommenterName() + ": " + item.GetTextComment();
            }            
        }
        else
        {
            result = "Without comments";
        }
        return result;
    }

}