using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    // This class represents a scripture, combining the reference and the text as words
    class Scripture
    {
        // Reference object for this scripture
        private Reference _reference;

        // List of Word objects representing each word in the scripture text
        private List<Word> _words;

        // Random generator for selecting words to hide
        private Random _random;

        // Constructor takes a reference and a full text string
        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();
            _random = new Random();

            // Split the text into words by spaces and create Word objects
            string[] wordArray = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string wordText in wordArray)
            {
                _words.Add(new Word(wordText));
            }
        }

        // Hide a specified number of random words that are not already hidden
        public void HideRandomWords(int numberToHide)
        {
            // Collect indexes of words that are currently visible
            List<int> visibleWordIndexes = new List<int>();
            for (int i = 0; i < _words.Count; i++)
            {
                if (!_words[i].IsHidden())
                {
                    visibleWordIndexes.Add(i);
                }
            }

            // If no visible words, nothing to hide
            if (visibleWordIndexes.Count == 0)
            {
                return;
            }

            // Hide words up to numberToHide or number of visible words, whichever is smaller
            int hideCount = Math.Min(numberToHide, visibleWordIndexes.Count);

            for (int i = 0; i < hideCount; i++)
            {
                // Select a random index from visible words
                int randomIndex = _random.Next(visibleWordIndexes.Count);

                // Hide the selected word
                _words[visibleWordIndexes[randomIndex]].Hide();

                // Remove the index from the list to avoid hiding the same word again
                visibleWordIndexes.RemoveAt(randomIndex);
            }
        }

        // Get the scripture text as a single string with hidden words replaced by underscores
        public string GetDisplayText()
        {
            // Start with the reference text
            string displayText = _reference.GetDisplayText() + "\n";

            // Concatenate the display text of each word with spaces
            foreach (Word word in _words)
            {
                displayText += word.GetDisplayText() + " ";
            }

            return displayText.TrimEnd();
        }

        // Check if all words are hidden
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
}
