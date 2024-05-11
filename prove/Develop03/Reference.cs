using System;

class Reference
{
    // Private fields to store the book, chapter, and verse
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    
    // Constructor for the Reference class with a single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

     // Constructor for the Reference class with a range of verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

     // Method to get the display text for the reference
    public string GetDisplayText()
    {
         // Initialize the display text with the book, chapter, and verse
        string displayText = _book + " " + _chapter + ":" + _verse;

        // If there is an end verse, add it to the display text
        if (_endVerse > _verse)
        {
            displayText += "-" + _endVerse;
        }
        // If there is no end verse, just add an empty string
        else if (_endVerse == 0)
        {
            displayText += "";
        }
         // Return the display text
        return displayText;
    }
}