using System;
using Tyuiu.MautalievSI.Sprint4.Task6.V5.Lib;

namespace Tyuiu.MautalievSI.Sprint4.Task6.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string[] array = { "Меркурий", "Венера", "Земля", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун" };

            Console.Title = "Спринт #4 | Выполнил: Мауталиев С.И. | Вариант #5";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #4                                                  *");
            Console.WriteLine("* Тема: Строковые массивы                                   *");
            Console.WriteLine("* Задание #6                                                 *");
            Console.WriteLine("* Вариант #5                                                 *");
            Console.WriteLine("* Выполнил: Мауталиев С.И.                                   *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Подсчитать количество элементов длиной 5                  *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");

            Console.Write("* Массив: ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");

            int result = ds.Calculate(array);
            Console.WriteLine($"* Количество элементов длиной 5 = {result}");

            Console.WriteLine("**************************************************************");
            Console.ReadKey();
        }
    }
}