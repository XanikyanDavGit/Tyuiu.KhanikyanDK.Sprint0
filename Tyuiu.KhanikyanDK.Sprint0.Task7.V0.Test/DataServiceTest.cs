using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KhanikyanDK.Sprint0.Task7.V0.Lib;
namespace Tyuiu.KhanikyanDK.Sprint0.Task7.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            int[] num1 = { 1, 1, 1, 1, 1 };
            int[] num2 = { 1, 1, 1, 1, 1 };
            int[] num3 = { 2, 2, 2, 2, 2 };

            int[] res = DataService.AdditionArrays(num1, num2);
            CollectionAssert.AreEqual(num3, res);
        }
    }
}
