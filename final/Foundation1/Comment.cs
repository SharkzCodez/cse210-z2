class Comment{
    private string _user;
    private string _text;

    public Comment (string user, string text)
    {
        _user = user;
        _text = text;
    }

        public string User
    {
        get { return _user; }
    }

        public string Text
    {
        get { return _text; }
    }
}