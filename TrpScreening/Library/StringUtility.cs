using System;
using System.Linq;

namespace Library
{
    public static class StringUtility
    {
        public static WordWithLength FindLongestWord(this string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }

            var longestWord = s.ReplaceNonLettersBySpaces()
                               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                               .OrderByDescending(w => w.Length)
                               .FirstOrDefault();

            return new WordWithLength(longestWord);
        }

        public static WordWithLength FindShortestWord(this string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }

            var longestWord = s.ReplaceNonLettersBySpaces()
                               .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                               .OrderBy(w => w.Length)
                               .FirstOrDefault();

            return new WordWithLength(longestWord);
        }

        private static string ReplaceNonLettersBySpaces(this string s)
        {
            return new string(s.Select(c => char.IsLetter(c) ? c : ' ').ToArray());
        }

    }
}
