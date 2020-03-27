using Library;
using NUnit.Framework;
using System;
using System.Linq;

namespace UnitTests
{
    public class ServiceTests
    {
        private Service service;

        [SetUp]
        public void Setup()
        {
            service = new Service();
        }

        [Test]
        public void Given_null_when_FindLongestWord_should_throw_exception()
        {
            Assert.Throws<ArgumentNullException>(() => service.FindLongestWord(null));
        }
        
        [Test]
        public void When_FindLongestWord_should_treat_any_supported_letters_as_letters()
        {
            var allLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var result = service.FindLongestWord(allLetters);

            Assert.That(result.Word, Is.EqualTo(allLetters));
            Assert.That(result.Length, Is.EqualTo(allLetters.Length));
        }

        [Test]
        public void When_FindLongestWord_should_treat_any_supported_non_letters_as_non_letters()
        {
            var allLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            var allSupportedCharacters = Enumerable.Range(0, 127).Select(i => (char)i);
            var nonLetterCharacters = Enumerable.Except(allSupportedCharacters, allLetters).ToArray();
           
            foreach (var nonLetterCharacter in nonLetterCharacters)
            {
                var result = service.FindLongestWord($"one{nonLetterCharacter}");
                Assert.That(result.Word, Is.EqualTo("one"));
                Assert.That(result.Length, Is.EqualTo(3));
            }
        }

        [TestCase("", null, 0, Description = "Empty string")]
        [TestCase("The cow jumped over the moon.", "jumped", 6, Description = "Basic scenario")]
        [TestCase("two,three", "three", 5, Description = "Non-letters are ignored")]
        [TestCase("King's", "King", 4, Description = "Apostrophe is treated as other non-letter characters")]
        [TestCase("HTML5 one", "HTML", 4, Description = "Digits are treated as other non-letter characters")]
        [TestCase("12345 word", "word", 4, Description = "Long numbers are ignored")]
        [TestCase("12345 ($   ", null, 0, Description = "String without letters - contains no words")]
        [TestCase("yes     no", "yes", 3, Description = "Multiple spaces ignored")]
        public void Given_sentence_when_FindLongestWord_should_return_expected_result(string s, string expectedWord, int expectedLength)
        {
            var result = service.FindLongestWord(s);

            Assert.That(result.Word, Is.EqualTo(expectedWord));
            Assert.That(result.Length, Is.EqualTo(expectedLength));
        }

        [Test]
        public void Given_null_when_FindShortestWord_should_throw_exception()
        {
            Assert.Throws<ArgumentNullException>(() => service.FindShortestWord(null));
        }

        [Test]
        public void When_FindShortestWord_should_treat_any_supported_letters_as_letters()
        {
            var allLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var result = service.FindShortestWord(allLetters);

            Assert.That(result.Word, Is.EqualTo(allLetters));
            Assert.That(result.Length, Is.EqualTo(allLetters.Length));
        }

        [Test]
        public void When_FindShortestWord_should_treat_any_supported_non_letters_as_non_letters()
        {
            var allLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            var allSupportedCharacters = Enumerable.Range(0, 127).Select(i => (char)i);
            var nonLetterCharacters = Enumerable.Except(allSupportedCharacters, allLetters).ToArray();

            foreach (var nonLetterCharacter in nonLetterCharacters)
            {
                var result = service.FindShortestWord($"one{nonLetterCharacter}");
                Assert.That(result.Word, Is.EqualTo("one"));
                Assert.That(result.Length, Is.EqualTo(3));
            }
        }

        [TestCase("", null, 0, Description = "Empty string")]
        [TestCase("abc ab abcd", "ab", 2, Description = "Basic scenario")]
        [TestCase("two,three", "two", 3, Description = "Non-letters are ignored")]
        [TestCase("King's", "s", 1, Description = "Apostrophe is treated as other non-letter characters")]
        [TestCase("HTML5 abcde", "HTML", 4, Description = "Digits are treated as other non-letter characters")]
        [TestCase("12345 word", "word", 4, Description = "Long numbers are ignored")]
        [TestCase("12345 ;!  ", null, 0, Description = "String without letters - contains no words")]
        [TestCase("yes     no", "no", 2, Description = "Multiple spaces ignored")]
        public void Given_sentence_when_FindShortestWord_should_return_expected_result(string s, string expectedWord, int expectedLength)
        {
            var result = service.FindShortestWord(s);

            Assert.That(result.Word, Is.EqualTo(expectedWord));
            Assert.That(result.Length, Is.EqualTo(expectedLength));
        }
    }
}