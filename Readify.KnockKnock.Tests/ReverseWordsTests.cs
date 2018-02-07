using Microsoft.VisualStudio.TestTools.UnitTesting;
using Readify.KnockKnock.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readify.KnockKnock.Tests
{
    [TestClass]
    public class ReverseWordsTests
    {

        [TestMethod]
        public void ReverseWords_NormalSentence()
        {

            string sentence = "I am going   to Australia";

            string newSentence = sentence.ReverseEachWord();

            Assert.AreEqual("I ma gniog   ot ailartsuA", newSentence);

        }
        [TestMethod]
        public void ReverseWords_EmptySentense()
        {
            string sentence = "";

            string newSentence = sentence.ReverseEachWord();

            Assert.AreEqual("", newSentence);
        }
        [TestMethod]
        public void ReverseWords_NullSentense()
        {
            string sentence = "null";

            string newSentence = sentence.ReverseEachWord();

            Assert.AreEqual("llun", newSentence);
        }
        [TestMethod]
        public void ReverseWords_SentenseIsNull()
        {
            string sentence =null;

            string newSentence = sentence.ReverseEachWord();

            Assert.AreEqual("", newSentence);
        }
        [TestMethod]
        public void ReverseWord_WithMultipleSpaces()
        {
            string sentence = "Waleed     Hammad";

            string newSentence = sentence.ReverseEachWord();

            Assert.AreEqual("deelaW     dammaH", newSentence);
        }


    }
}
