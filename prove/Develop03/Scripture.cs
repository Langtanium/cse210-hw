using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word wordObject = new Word(word);
            _words.Add(wordObject);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rndGen = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int rnd = rndGen.Next(0, _words.Count);
            if (_words[rnd].IsHidden() == true && !(_words.All(c=> c.IsHidden() == true)))
            {
                i = i-1;
            }
            else
            {
                _words[rnd].Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += (" " + word.GetDisplayText());
        }
        return _reference.GetDisplayText() + " " + scriptureText;
    }

    public bool IsCompletelyHidden()
    {
        bool hiddenAll = _words.All(c=> c.IsHidden() == true);
        return hiddenAll;
    }
}