using System;
using DSAndAlgorithms.InbuiltCollection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSAndAlgorithms.Tests
{
    [TestClass]
    public class YieldTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //------------------------------------------------------------
            // If you debug this, you will see call to GetNumbers and then it wil return and then go back to second yield and then third
            foreach (var number in Yield.GetNumbers())
            {
                Console.WriteLine(number);
            }

            //------------------------------------------------------------

            // Here the GetNumbers yield would not be called. It will be called only we try to iterate over the 
            var numbers = Yield.GetNumbers();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
