namespace ScriptureMemorizer
{
    public class Reference
    {
        public string Book { get; private set; }
        public int StartChapter { get; private set; }
        public int StartVerse { get; private set; }
        public int? EndVerse { get; private set; }

        // Constructor for single verse
        public Reference(string book, int chapter, int verse)
        {
            Book = book;
            StartChapter = chapter;
            StartVerse = verse;
            EndVerse = null;
        }

        // Constructor for verse range
        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            Book = book;
            StartChapter = chapter;
            StartVerse = startVerse;
            EndVerse = endVerse;
        }

        public override string ToString()
        {
            if (EndVerse.HasValue)
                return $"{Book} {StartChapter}:{StartVerse}-{EndVerse}";
            else
                return $"{Book} {StartChapter}:{StartVerse}";
        }
    }
}
