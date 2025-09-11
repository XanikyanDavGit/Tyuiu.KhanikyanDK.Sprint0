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
            Console.WriteLine(DataService.Addition(42, 48));
            Console.WriteLine(DataService.Subtraction(42, 48));
            Console.WriteLine(DataService.Multiplication(42, 48));
            Console.WriteLine(DataService.Division(42, 8));
            Console.ReadKey();
        }
    }
}
