using System;
using Tyuiu.MautalievSI.Sprint4.Task2.V19.Lib;

namespace Tyuiu.MautalievSI.Sprint4.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            int[] array = new int[14];

            Console.Title = "Спринт #4 | Выполнил: Мауталиев С.И. | Вариант #19";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #4                                                  *");
            Console.WriteLine("* Тема: Массивы (случайные значения)                         *");
            Console.WriteLine("* Задание #2                                                 *");
            Console.WriteLine("* Вариант #19                                                *");
            Console.WriteLine("* Выполнил: Мауталиев С.И.                                   *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Найти сумму нечетных элементов массива                     *");
            Console.WriteLine("* (значения от 4 до 9)                                       *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");

            Console.Write("* Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(4, 10);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");

            int result = ds.Calculate(array);
            Console.WriteLine($"* Сумма нечетных элементов = {result}");

            Console.WriteLine("**************************************************************");
            Console.ReadKey();
        }
    }
}