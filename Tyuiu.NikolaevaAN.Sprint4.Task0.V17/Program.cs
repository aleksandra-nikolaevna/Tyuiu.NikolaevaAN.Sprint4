using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NikolaevaAN.Sprint4.Task0.V17.Lib;

namespace Tyuiu.NikolaevaAN.Sprint4.Task0.V17
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Николаева А. Н. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнила: Николаева Александра Николаевна | ПКТб-23-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая подсчитает сумму четных элементов массива.  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
            Console.Write("Исходный массив: { ");
            for (int i = 0; i < numsArray.Length; i++)
            {
                if (i < 9)
                {
                    Console.Write(numsArray[i] + ", ");
                }
                else
                {
                    Console.Write(numsArray[i] + " ");
                }
            }
            Console.WriteLine("}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Сумма чётных элементов массива = " + ds.GetSumEvenArrEl(numsArray));
            Console.ReadKey();
        }
    }
}
