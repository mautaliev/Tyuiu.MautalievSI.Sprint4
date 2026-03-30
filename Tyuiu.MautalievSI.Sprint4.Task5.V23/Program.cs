using System;
using Tyuiu.MautalievSI.Sprint4.Task5.V23.Lib;

namespace Tyuiu.MautalievSI.Sprint4.Task5.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            int[,] matrix = new int[5, 5];

            Console.Title = "Спринт #4 | Выполнил: Мауталиев С.И. | Вариант #23";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #4                                                  *");
            Console.WriteLine("* Тема: Двумерные массивы (случайные значения)               *");
            Console.WriteLine("* Задание #5                                                 *");
            Console.WriteLine("* Вариант #23                                                *");
            Console.WriteLine("* Выполнил: Мауталиев С.И.                                   *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Заменить отрицательные элементы массива на 0               *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("* ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(-4, 9);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");

            int[,] result = ds.Calculate(matrix);

            for (int i = 0; i < result.GetLength(0); i++)
            {
                Console.Write("* ");
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    Console.Write(result[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("**************************************************************");
            Console.ReadKey();
        }
    }
}