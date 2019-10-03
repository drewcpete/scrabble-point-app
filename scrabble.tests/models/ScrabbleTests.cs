using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;

namespace Scrabble.TestTools
{
    [TestClass]
    public class ScrabbleTest
    {
        [TestMethod]
        public void Scrabble_AssignWord_WordIsAssigned()
        {
            string newWord = "Octothorpe";
            string result = newWord;
            Assert.AreEqual(newWord, result);
        }
        [TestMethod]
        public void  Scrabble_WordToCharArray_CharArray()
        {
            string newWord = "Octothorpe";
            char[] correctArray = {'O', 'c', 't', 'o', 't', 'h', 'o', 
            'r', 'p', 'e'};
            char[] newArray = newWord.ToCharArray();
            CollectionAssert.AreEqual(correctArray, newArray);
        }
        [TestMethod]
        public void Scrabble_CheckWordFor1PointChars_1pointChar()
        {
            string newWord = "little";
            int newValue = Game.CheckCharPoints(newWord);
            Assert.AreEqual(6, newValue);
        }
    }
}