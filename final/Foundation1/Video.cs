class Video
{
    private string _title;
    private string _author;
    private int _videoSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int videoSeconds)
    {
        _title = title;
        _author = author;
        _videoSeconds = videoSeconds;
        _comments = new List<Comment>();
    }
    public string Title
    {
        get { return _title; }
    }
    public string Author
    {
        get { return _author; }
    }

    public int VideoSeconds
    {
        get { return _videoSeconds; }
    }

    #region 
   
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public List<Comment> GetComments()
    {
        return new List<Comment>(_comments);
    }
    #endregion

    public int GetNumberOfComments()
    {
        return _comments.Count;

    }

}