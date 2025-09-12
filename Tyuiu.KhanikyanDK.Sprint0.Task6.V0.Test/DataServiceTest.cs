using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KhanikyanDK.Sprint0.Task6.V0.Lib;

namespace Tyuiu.KhanikyanDK.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {
            var numbers = new int[] {1, 2, 3, 4, 5, 6, 7};
            var res = DataService.AdditionArray(numbers);
            Assert.AreEqual(28, res);
        }
        public void CheckSubstractionArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubstrictionArray(numbers);
            Assert.AreEqual(-15, res);
        }
        public void CheckMultArrayValid()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultArray(numbers);
            Assert.AreEqual(120, res);
        }
    }
}
