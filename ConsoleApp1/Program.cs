int[] arr = { -2, 3, -5, 7, -1, 4 };
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
        count++;
}

Console.WriteLine(count);