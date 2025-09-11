using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KhanikyanDK.Sprint0.Task4.V0.Lib;
namespace Tyuiu.KhanikyanDK.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionalValid()
        {
            Assert.AreEqual(10, DataService.Addition(5,5));
        }
        public void CheckSubtractionValid()
        {
            Assert.AreEqual(7, DataService.Subtraction(9, 2));
        }
        public void CheckMultiplicationValid()
        {
            Assert.AreEqual(20, DataService.Multiplication(5, 4));
        }
        public void CheckDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(27, 9));
        }
    }
}
