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
        // If hidden, return underscores matching the word length
        // Otherwise, return the word text itself
        public string GetDisplayText()
        {
            if (_isHidden)
            {
                if (_text.Length > 1)
                {
                    // Show the first letter and replace the rest with underscores
                    return _text[0] + new string('_', _text.Length - 1);
                }
                else
                {
                    // If the word is a single letter, just show underscore
                    return "_";
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
