using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NikolaevaAN.Sprint4.Task3.V19.Lib;

namespace Tyuiu.NikolaevaAN.Sprint4.Task3.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { 6, 5, 6, 3, 8 }, { 9, 4, 4, 3, 4 },
                { 3, 3, 6, 8, 6 }, { 6, 5, 3, 4, 3 }, { 9, 3, 5, 3, 7} };
            int rows = mas2.GetUpperBound(0) + 1;
            int columns = mas2.Length / rows;

            Console.Title = "Спринт #4 | Выполнила: Николаева А. Н. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнила: Николаева Александра Николаевна | ПКТб-23-2                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая подсчитает количество четных элементов во   *");
            Console.WriteLine("* всем массиве.                                                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas2[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Кол-во чётных элементов в массиве = " + ds.Calculate(mas2));
            Console.ReadKey();
        }
    }
}
