using System;

class Word
{
    private string word;
    private bool isHidden;

    public bool Hidden { get; internal set; }
    public string Text { get; internal set; }

    public Word(string _word)
    {
        word = _word;
        isHidden = false;
    }

    public bool GetIsHidden()
    {
        return isHidden;
    }

    public void SetIsHidden(bool _isHidden)
    {
        isHidden = _isHidden;
    }

    public string GetWord()
    {
        return word;
    }

    internal void Reveal()
    {
        throw new NotImplementedException();
    }
}