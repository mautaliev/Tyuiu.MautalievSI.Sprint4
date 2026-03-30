int[,] array = new int[,] { { 3, 4, 9 }, { 2, 6, 7 }, { 7, 1, 5 } };
int count = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] % 2 == 0)
        {
            count++;
        }
    }
}

Console.WriteLine(count);