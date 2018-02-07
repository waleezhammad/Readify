using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readify.KnockKnock.Business
{
    public static class ReverseWords
    {
        public static string ReverseEachWord(this string sentence)
        {
            if (string.IsNullOrEmpty(sentence))
                return string.Empty;

            List<string> wordsInSentence = sentence.Split(" ".ToCharArray()).Where(c => !string.IsNullOrWhiteSpace(c)).ToList();
            foreach (var word in wordsInSentence)
            {
                string reversedWord = new string(word.Reverse().ToArray());
                sentence = sentence.Replace(word, reversedWord);
            }

            return sentence;
        }
    }
}
