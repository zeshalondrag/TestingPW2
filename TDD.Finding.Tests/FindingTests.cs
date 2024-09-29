using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Finding.Tests
{
    [TestClass]
    public class FindingTests
    {
        [TestMethod]
        public void FindingTheLine_FindShortestWord_asReturn()
        {
            string proposal = "Воспринимайте вызовы как возможности для роста";
            StringAssert.Contains("как", Finding1.FindShortestWord(proposal));
        }

        [TestMethod]
        public void FindingTheLine_CountWords_6Return()
        {
            string proposal = "Воспринимайте вызовы как возможности для роста";
            Assert.AreEqual(6, Finding1.CountWords(proposal));
        }

        [TestMethod]
        public void FindingTheLine_CountCharacters_46Return()
        {
            string proposal = "Воспринимайте вызовы как возможности для роста";
            Assert.AreEqual(46, Finding1.CountCharacters(proposal));
        }

        [TestMethod]
        public void FindingTheLine_FindNinthCharacter_мReturn()
        {
            string proposal = "Воспринимайте вызовы как возможности для роста";
            Assert.AreEqual('м', Finding1.FindNinthCharacter(proposal));
        }

        [TestMethod]
        public void FindingTheLine_CountDigits_1Return()
        {
            string proposal = "Воспринимайте вызовы как возможности для роста 8";
            Assert.AreEqual(1, Finding1.CountDigits(proposal));
        }

        [TestMethod]
        public void FindingTheLine_FindMaxConsecutiveDigits_3Return()
        {
            string proposal = "Воспринимайте 52 вызовы как возможности для роста 887";
            Assert.AreEqual(3, Finding1.FindMaxConsecutiveDigits(proposal));
        }

        [TestMethod]
        public void FindingTheLine_CountAmCombinations_2Return()
        {
            string proposal = "Воспринимайте вызовы как возможности для роста P.S ам ам ням";
            Assert.AreEqual(2, Finding1.CountAmCombinations(proposal));
        }
    }
}