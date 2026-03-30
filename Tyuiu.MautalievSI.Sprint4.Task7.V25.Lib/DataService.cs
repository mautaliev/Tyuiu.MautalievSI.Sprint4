using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.MautalievSI.Sprint4.Task7.V25.Lib
{
    public class DataService : ISprint4Task7V25
    {
        public int Calculate(int n, int m, string value)
        {
            int sum = 0;
            int index = 0;

            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Convert.ToInt32(value[index].ToString());

                    if (matrix[i, j] % 2 == 0)
                    {
                        sum += matrix[i, j];
                    }

                    index++;
                }
            }

            return sum;
        }
    }
}