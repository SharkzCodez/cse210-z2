using System;

public class Word
{
    private string _text = "";
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide(bool isHidden)
    {
        _isHidden = isHidden;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (!_isHidden)
        {
            return _text;
        }
        else
        {
            string temporaryString = "";
            for (int i = 0; i < _text.Length; i++)
            {
                temporaryString += "_";
            }
            return temporaryString;
        }
    }
}