using System;
using Tyuiu.MautalievSI.Sprint4.Task1.V29.Lib;

namespace Tyuiu.MautalievSI.Sprint4.Task1.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[] array = new int[14];

            Console.Title = "Спринт #4 | Выполнил: Мауталиев С.И. | Вариант #29";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #4                                                  *");
            Console.WriteLine("* Тема: Массивы (ввод с клавиатуры)                          *");
            Console.WriteLine("* Задание #1                                                 *");
            Console.WriteLine("* Вариант #29                                                *");
            Console.WriteLine("* Выполнил: Мауталиев С.И.                                   *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Найти сумму нечетных элементов массива                     *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ВВОД ДАННЫХ:                                               *");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите элемент {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");

            int result = ds.Calculate(array);
            Console.WriteLine($"* Сумма нечетных элементов = {result}");

            Console.WriteLine("**************************************************************");
            Console.ReadKey();
        }
    }
}