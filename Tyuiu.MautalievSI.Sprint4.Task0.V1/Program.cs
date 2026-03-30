using System;
using Tyuiu.MautalievSI.Sprint4.Task0.V1.Lib;

namespace Tyuiu.MautalievSI.Sprint4.Task0.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[] array = { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };

            Console.Title = "Спринт #4 | Выполнил: Мауталиев С.И. | Вариант #1";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #4                                                  *");
            Console.WriteLine("* Тема: Массивы                                              *");
            Console.WriteLine("* Задание #0                                                 *");
            Console.WriteLine("* Вариант #1                                                 *");
            Console.WriteLine("* Выполнил: Мауталиев С.И.                                   *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Найти сумму четных элементов массива                       *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");

            Console.Write("* Массив: ");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");

            int result = ds.GetSumEvenArrEl(array);
            Console.WriteLine($"* Сумма четных элементов = {result}");

            Console.WriteLine("**************************************************************");
            Console.ReadKey();
        }
    }
}