using System;
using Tyuiu.MautalievSI.Sprint4.Task7.V25.Lib;

namespace Tyuiu.MautalievSI.Sprint4.Task7.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int n = 4;
            int m = 3;
            string value = "348561792486";

            Console.Title = "Спринт #4 | Выполнил: Мауталиев С.И. | Вариант #25";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #4                                                  *");
            Console.WriteLine("* Тема: Преобразование строки в матрицу                     *");
            Console.WriteLine("* Задание #7                                                 *");
            Console.WriteLine("* Вариант #25                                                *");
            Console.WriteLine("* Выполнил: Мауталиев С.И.                                   *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Преобразовать строку в матрицу и найти сумму четных       *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine($"* Строка = {value}");
            Console.WriteLine($"* Размер матрицы: {n}x{m}");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");

            int result = ds.Calculate(n, m, value);
            Console.WriteLine($"* Сумма четных элементов = {result}");

            Console.WriteLine("**************************************************************");
            Console.ReadKey();
        }
    }
}