using System;

public class Word
{
    private string _text;
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            int textLength = _text.Length;
            string text = "";

            for (int i = 0; i < textLength; i++)
            {
                text += "_";
            }

            return text;
        }
        else
        {
            return _text;
        }
    }
}