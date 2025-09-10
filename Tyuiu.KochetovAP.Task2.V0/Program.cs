using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tyuiu.KochetovAP.Task2.V0.Lib;
using System.Threading.Tasks;


namespace Tyuiu.KochetovAP.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Андрей"));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
