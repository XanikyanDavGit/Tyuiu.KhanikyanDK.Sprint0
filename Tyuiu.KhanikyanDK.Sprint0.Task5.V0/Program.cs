using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KhanikyanDK.Sprint0.Task4.V0.Lib;
namespace Tyuiu.KhanikyanDK.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(42, 48));
            Console.WriteLine("A - B = " + DataService.Subtraction(42, 48));
            Console.WriteLine("A * B = " + DataService.Multiplication(42, 4));

            Console.WriteLine("A / B = " + DataService.Division(4, 2));
            Console.ReadKey();
        }
    }
}
