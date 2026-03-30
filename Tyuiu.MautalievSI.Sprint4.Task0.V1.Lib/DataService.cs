using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MautalievSI.Sprint4.Task0.V1.Lib
{
    public class DataService : ISprint4Task0V1
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int sum = 0;

            foreach (int item in array)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }

            return sum;
        }
    }
}