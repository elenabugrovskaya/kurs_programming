// Найти два наименьших положительных (минимальных) элементов массива.

int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
for (int i = 0; i < n; i++)
{
    arr[i] = new Random().Next(-10, 10);
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

int min1 = arr[0];
int min2 = arr[1];

for (int j = 0; j < n; j++)
{
    if (arr[j] < min1)
    {
        min1 = arr[j];
    }
    else if (arr[j] < min2 && arr[j] > min1)
    {
        min2 = arr[j];
    }
}

Console.WriteLine(min1);
Console.WriteLine(min2);