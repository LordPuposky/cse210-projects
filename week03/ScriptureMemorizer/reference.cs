namespace ScriptureMemorizer
{
    // This class represents the scripture reference, including book, chapter, and verses
    class Reference
    {
        // Private attributes to store book, chapter, starting verse, and optional ending verse
        private string _book;
        private int _chapter;
        private int _verse;
        private int _endVerse;

        // Constructor for a single verse reference, e.g., "John 3:16"
        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = verse; // endVerse same as verse for single verse references
        }

        // Constructor for a range verse reference, e.g., "Proverbs 3:5-6"
        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _verse = startVerse;
            _endVerse = endVerse;
        }

        // Method to get the formatted reference text
        public string GetDisplayText()
        {
            if (_verse == _endVerse)
            {
                // Single verse format: Book Chapter:Verse
                return $"{_book} {_chapter}:{_verse}";
            }
            else
            {
                // Verse range format: Book Chapter:StartVerse-EndVerse
                return $"{_book} {_chapter}:{_verse}-{_endVerse}";
            }
        }
    }
}
