int[,] array = new int[,]
{
    { -10, 9, -10 },
    { -2, 4, 8 },
    { 9, -6, 4 }
};

int s = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[i, j] % 2 == 0)
        {
            s += array[i, j];
        }
    }
}

Console.WriteLine(s);