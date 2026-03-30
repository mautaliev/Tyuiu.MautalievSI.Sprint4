using System;
using Tyuiu.MautalievSI.Sprint4.Task3.V27.Lib;

namespace Tyuiu.MautalievSI.Sprint4.Task3.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] array = new int[,]
            {
                {4, 3, 5, 5, 3},
                {6, 7, 4, 4, 3},
                {3, 3, 7, 3, 6},
                {3, 4, 3, 7, 7},
                {3, 5, 6, 3, 6}
            };

            Console.Title = "Спринт #4 | Выполнил: Мауталиев С.И. | Вариант #27";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #4                                                  *");
            Console.WriteLine("* Тема: Двумерные массивы                                   *");
            Console.WriteLine("* Задание #3                                                 *");
            Console.WriteLine("* Вариант #27                                                *");
            Console.WriteLine("* Выполнил: Мауталиев С.И.                                   *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Подсчитать количество четных элементов массива            *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("* ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");

            int result = ds.Calculate(array);
            Console.WriteLine($"* Количество четных элементов = {result}");

            Console.WriteLine("**************************************************************");
            Console.ReadKey();
        }
    }
}