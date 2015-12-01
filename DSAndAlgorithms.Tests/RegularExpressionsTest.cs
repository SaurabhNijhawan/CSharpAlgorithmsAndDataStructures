using System;
using DSAndAlgorithms.StringAlgorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSAndAlgorithms.RegularExpressions;

namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class RegularExpressionsTest
    {
        [TestMethod]
        public void RegularExpressions_IsMatch_Pattern_In_Subject_Must_Return_True()
        {

            Assert.IsTrue(RegularExpression.IsMatch("Cat", "DogCat"));
        }

    }
}
