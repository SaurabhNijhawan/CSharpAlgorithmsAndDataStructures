using System;
using DSAndAlgorithms.InbuiltCollection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DSAndAlgorithms;

namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void TestMethod1()
        {
                Solution s = new Solution();
           var p = s.solution("13+62*7+*");
        }
    }
}
