using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KhanikyanDK.Sprint0.Task6.V0.Lib;

namespace Tyuiu.KhanikyanDK.Sprint0.Task6.V0
{
    [TestClass]
    class Program
    {


        [TestMethod]
        static void Main(string[] args)
        {

        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма эл-ов массива = " + DataService.AdditionArray(numsArray));
            Console.WriteLine("Разность эл-ов массива = " + DataService.SubstrictionArray(numsArray));
            Console.WriteLine("Произведение эл-ов массива = " + DataService.MultArray(numsArray));
            Console.ReadKey();
        }
        }
    }
}
