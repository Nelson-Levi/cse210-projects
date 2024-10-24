using System;

public class Scripture
{
    // Identify the parts of the scripture - the text inside, and the reference from the Reference class.
    private List<Word> _words;
    private Reference _scriptureReference;

    public Scripture(Reference scriptureReference, string scriptureText)
    {
        _scriptureReference = scriptureReference;
        // The list will be populated by each individual word in the scripture.
        _words = scriptureText.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        // By default, we want to hide 3 words at a time
        int hideTotal = 3;

        // Create a list of words that are not hidden using .Where() and convert to a list with .ToList().
        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        // If there's less than 3 words left, then adjust the hideTotal so there's no errors.
        hideTotal = Math.Min(hideTotal, visibleWords.Count);

        for (int i = 0; i < hideTotal; i++)
        {
            // Pick a random word to hide
            int randomWordIndex = random.Next(visibleWords.Count);
            visibleWords[randomWordIndex].SetHidden();
            // Don't forget to take it out of the visible words list, otherwise you could hide it over and over
            visibleWords.RemoveAt(randomWordIndex);
        }
    }

    // This method will combine the reference with the scripture.
    public string GetFullScripture()
    {
        // This will activate if the scripture has multiple verses.
        // .IsNullOrEmpty checks if the _end string exists. If it does, then the correct method will be called.
        if (!string.IsNullOrEmpty(_scriptureReference._end))
        {
            string reference = _scriptureReference.GetManyVerseReference();
            // Join the hidden words with the visible words.
            string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
            return $"{reference}: {scriptureText}";
        }
        else
        {
            // This will activate if the scripture has only one verse.           
            string reference = _scriptureReference.GetOneVerseReference();
            // Join the hidden words with the visible words.
            string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
            return $"{reference}: {scriptureText}";
        }
    }

    // This method checks if all the words are hidden.
    public bool AreAllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}