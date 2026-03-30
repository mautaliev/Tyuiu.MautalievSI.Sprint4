using System;
using Tyuiu.MautalievSI.Sprint4.Task4.V7.Lib;

namespace Tyuiu.MautalievSI.Sprint4.Task4.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5];

            Console.Title = "Спринт #4 | Выполнил: Мауталиев С.И. | Вариант #7";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #4                                                  *");
            Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                *");
            Console.WriteLine("* Задание #4                                                 *");
            Console.WriteLine("* Вариант #7                                                 *");
            Console.WriteLine("* Выполнил: Мауталиев С.И.                                   *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Найти сумму нечетных элементов массива                     *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ВВОД ДАННЫХ:                                               *");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"Введите элемент [{i},{j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");

            int result = ds.Calculate(matrix);
            Console.WriteLine($"* Сумма нечетных элементов = {result}");

            Console.WriteLine("**************************************************************");
            Console.ReadKey();
        }
    }
}