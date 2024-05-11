using System;

class Word
{
     // Private fields to store the text of the word and whether it is hidden
    private string _text;
    private bool _isHidden;

    // Constructor for the Word class
    public Word(string text)
    {
        // Initialize the text of the word
        _text = text;
        // Initialize the word as not hidden
        _isHidden = false;
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

    // Method to get the display text for the word
    public string GetDisplayText()
    {
         // If the word is hidden, return an underscore
        if (IsHidden())
        {
            return "_";
        }
        // If the word is not hidden, return the text of the word
        else
        {
            return _text;
        }
    }
}