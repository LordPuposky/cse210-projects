namespace ScriptureMemorizer
{
    // This class represents a single word in the scripture
    class Word
    {
        // Private attribute to hold the actual text of the word
        private string _text;

        // Private attribute to track if the word is hidden or visible
        private bool _isHidden;

        // Constructor that takes the word text as a parameter
        public Word(string text)
        {
            _text = text;
            _isHidden = false;  // By default, the word is visible
        }

        // Method to hide the word
        public void Hide()
        {
            _isHidden = true;
        }

        // Method to show the word (unhide)
        public void Show()
        {
            _isHidden = false;
        }

        // Method to check if the word is hidden
        public bool IsHidden()
        {
            return _isHidden;
        }

        // Method to get the display text of the word:
        // If hidden, return underscores matching the word length, preserving punctuation
        // Otherwise, return the word text itself
        public string GetDisplayText()
        {
            if (_isHidden)
            {
                string coreText = _text;
                string punctuation = "";

                // Check if last character is punctuation
                char lastChar = coreText[coreText.Length - 1];
                if (char.IsPunctuation(lastChar))
                {
                    punctuation = lastChar.ToString();
                    coreText = coreText.Substring(0, coreText.Length - 1);
                }

                if (coreText.Length > 1)
                {
                    // Show the first letter and replace the rest with underscores
                    return coreText[0] + new string('_', coreText.Length - 1) + punctuation;
                }
                else if (coreText.Length == 1)
                {
                    return "_" + punctuation;
                }
                else
                {
                    return punctuation; // In case the word was just punctuation
                }
            }
            else
            {
                // If not hidden, show the full word
                return _text;
            }
        }
    }
}
