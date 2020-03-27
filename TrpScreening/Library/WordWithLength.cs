namespace Library
{
    public class WordWithLength
    {
        public string Word { get; private set; }
        public int Length => Word != null ? Word.Length : 0;

        public WordWithLength(string word)
        {
            Word = word;
        }
    }
}
