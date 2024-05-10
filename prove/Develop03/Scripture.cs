using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    
    public Scripture (Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenWords = 0;
        int wordsLeft = _words.Count;

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
            int randomIndex =  random.Next(_words.Count);
            Word randomWord = _words[randomIndex];
            if (!randomWord.IsHidden())
            {
                randomWord.Hide();
                hiddenWords++;
                wordsLeft--;
            }
            else
            {
                i--;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

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
