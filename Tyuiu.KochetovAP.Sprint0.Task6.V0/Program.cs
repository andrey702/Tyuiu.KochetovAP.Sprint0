﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KochetovAP.Sprint0.Task6.V0.Lib;

namespace Tyuiu.KochetovAP.Sprint0.Task6.V0
{
    internal class Progarm
    {
        static void Main(string[] args)
        {
            int[] numsArray = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(numsArray));
            Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(numsArray));
            Console.WriteLine("Произвеление элемнтов массива = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}
