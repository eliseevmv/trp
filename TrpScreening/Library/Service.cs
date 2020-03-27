using System;
using System.Linq;

namespace Library
{
    public class Service
    {
        private readonly char[] CharactersToExclude; // Depends on requirements - see readme.txt

        public Service()
        {
            CharactersToExclude = Enumerable.Range(0, 255)
                                            .Select(i => (char)i)
                                            .Where(c => !char.IsLetter(c))
                                            .ToArray();
        }

        public WordWithLength FindLongestWord(string s)
        {
            if (s==null)
            {
                throw new ArgumentNullException(nameof(s));
            }

            var longestWord = s.Split(CharactersToExclude,StringSplitOptions.RemoveEmptyEntries)
                               .OrderByDescending(w => w.Length)
                               .FirstOrDefault();

            return new WordWithLength(longestWord);
        }

        public WordWithLength FindShortestWord(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(nameof(s));
            }

            var longestWord = s.Split(CharactersToExclude, StringSplitOptions.RemoveEmptyEntries)
                               .OrderBy(w => w.Length)
                               .FirstOrDefault();

            return new WordWithLength(longestWord);
        }
    }
}
