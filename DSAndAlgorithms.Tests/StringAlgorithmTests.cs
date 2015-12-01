using System;
using DSAndAlgorithms.Algorithms.StringAlgorithms;
using DSAndAlgorithms.StringAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class StringAlgorithmTests
    {
        [TestMethod]
        public void Anagrams_AreAnagrams_2_String_Anagrams_Must_Return_True()
        {

            Assert.IsTrue(Anagrams.AreTwoStringsAnagrams("Hello", "elolH"));
        }

        [TestMethod]
        public void Anagrams_AreAnagrams_2_String_Anagrams_But_Different_Case_Must_Return_True()
        {
            Assert.IsTrue(Anagrams.AreTwoStringsAnagrams("Hello", "eloLh"));
        }

        [TestMethod]
        public void Anagrams_AreAnagrams_1_String_Empty_Must_Return_False()
        {
            Assert.IsFalse(Anagrams.AreTwoStringsAnagrams("Hello", ""));
        }

        [TestMethod]
        public void Anagrams_AreAnagrams_1_String_Null_Must_Return_False()
        {
            Assert.IsFalse(Anagrams.AreTwoStringsAnagrams("Hello", null));
        }

        [TestMethod]
        public void Anagrams_AreAnagrams_Both_Strings_Null_Must_Return_False()
        {
            Assert.IsFalse(Anagrams.AreTwoStringsAnagrams(null, null));
        }

        [TestMethod]
        public void Anagrams_AreTwoStrings_Anagrams_Strings_Not_Anagrams_Must_Return_False()
        {
            Assert.IsFalse(Anagrams.AreTwoStringsAnagrams("Cad", "Mad"));
        }

        [TestMethod]
        public void Anagrams_DisplayAllAnagramsTogether()
        {
            // Arrange
            string[] input = {"cat", "mat", "bat", "tac", "tab"};
            Anagrams.DisplayAllAnagramsTogether(input);
            
        }


        [TestMethod]
        public void Combinotorics_PrintAllPossibleWordsByPressingNDigits_SholdReturn_Expected_Strings()
        {
            // Arrange
            Assert.AreEqual(36, Combinotorics.PrintAllPossibleWordsByPressingNDigits(new[] {4, 3, 7}).Count);
            Assert.AreEqual(108, Combinotorics.PrintAllPossibleWordsByPressingNDigits(new[] { 4, 3, 7, 5 }).Count);
            Assert.AreEqual(48, Combinotorics.PrintAllPossibleWordsByPressingNDigits(new[] { 4, 9, 7 }).Count);
        }

        [TestMethod]
        public void LCS_LongestCommonSubSequenceLength_Success_Test()
        {
            // Arrange
            string a = "ABACEB";
            String b = "ADBAACEB";

            // Act
            var length = LCS.LongestCommonSubSequenceLength(a.ToCharArray(), b.ToCharArray());

            // Assert

            Assert.AreEqual(6, length);
        }


        [TestMethod]
        public void KMP_Search_String()
        {
            string stringW = "put";
            string stringS = "computer";

            char[] W = stringW.ToCharArray();
            char[] S = stringS.ToCharArray();

            StringSearcher ss = new StringSearcher(W);
            int ix = ss.Search(S);
            Console.WriteLine("Location of W in S is " + ix);
        }


    }
}
