using System;

public class Word
{
    private string _text;
    private string _punctuation;
    private bool _isHidden;

    public Word(string text)
    {
        // This is handles punctuation so it will be displayed and NOT blanked out.
        if (text.EndsWith('.') || text.EndsWith(',') || text.EndsWith(';') || text.EndsWith(':') || text.EndsWith('!'))
        {
            // Save the last character as the punctuation
            _punctuation = text[^1].ToString();
            // Save everything BUT the last character as the text
            _text = text[..^1];
        }
        else
        {
            _text = text;
            _punctuation = "";
        }
        _isHidden = false;
    }

    // This will change the _isHidden value to true.
    public void SetHidden()
    {
        _isHidden = true;
    }

    public string GetDisplayText()
    {
        // If the word is hidden, replace it with an appropriate amount of underscores
        if (_isHidden)
        {
            return new string('_', _text.Length) + _punctuation;
        }
        // Otherwise, return the word as is
        return _text + _punctuation;
    }

    // This method checks if the word is hidden.
    public bool IsHidden()
    {
        return _isHidden;
    }
}