using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KhanikyanDK.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KhanikyanDK.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Davo";

            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Davo", res);
        }
    }
}