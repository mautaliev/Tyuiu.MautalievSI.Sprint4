int[] a = { 11, 5, 20, 3, 14 };
int[] b = { 8, 13, 2, 7, 9 };

int count = 0;

for (int i = 0; i < a.Length; i++)
{
    if (a[i] > b[i])
    {
        count++;
    }
}

Console.WriteLine(count);