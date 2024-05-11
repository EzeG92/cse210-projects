using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    
    // Constructor for the Scripture class
    // Takes in a reference and the text of the scripture
    public Scripture (Reference reference, string text)
    {
        // Initialize the reference field with the given reference
        _reference = reference;
        // Initialize the list of words with an empty list
        _words = new List<Word>();

        // Split the text into an array of words
        string[] wordsArray = text.Split(' ');
        // Add each word in the array to the list of words as a new Word object
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    // Method to hide a random number of words in the scripture
    // Takes in the number of words to hide
    public void HideRandomWords(int numberToHide)
    {   
        // Initialize a random number generator
        Random random = new Random();
        int hiddenWords = 0;
        int wordsLeft = _words.Count;

        // Loop through the number of words to hide
        for (int i = 0; i < numberToHide; i++)
        {   
            if (wordsLeft <=3)
            {
                // If there are less than 3 words left, hide all remaining words
                foreach (Word word in _words)
                {
                    if (!word.IsHidden())
                    {
                        word.Hide();
                        hiddenWords++;
                    }
                }
            }
            
            // Generate a random index for a word in the list
            int randomIndex =  random.Next(_words.Count);
            // Get the word at the random index
            Word randomWord = _words[randomIndex];
            // If the word is not already hidden, hide it
            if (!randomWord.IsHidden())
            {
                randomWord.Hide();
                hiddenWords++;
            }
            else
            {
                // If the word is already hidden, decrement the loop counter
                i--;
            }
            wordsLeft = _words.Count - hiddenWords;
        }
    }

    // Method to get the display text of the scripture
    // Returns a string of the display text
    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            // Add the display text of each word to the display text string
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    // Method to check if all the words in the scripture are hidden
    // Returns a boolean indicating whether all the words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
