// Дан одномерный массив целых чисел. Найдите сколько раз в нем повторяется самое частое число.
// Пр, 15 33 24 23 17 23 -> 3

int[] CreateMas(int n)
{
    int[] arr = new int[n];
    for(int i = 0; i<n; i++)
    {
        arr[i] = new Random().Next(2, 10);
    }
    return arr;
}
void Print(int[] arr)
{
    Console.WriteLine(String.Join(" ", arr));
}

int kolichestvo(int[] arr)
{
    int k = 0;
    int max = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        k = 1;
        for (int j = i+1; j < arr.Length; j++)
        {
            if(arr[i] == arr[j]) k++;
        }
        if (k > max)
        {
            max = k;
        }
     
    } 
    return max;
} 
Console.Write("Введите количество элементов: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
array = CreateMas(n);
Print(array);
Console.WriteLine(kolichestvo(array));
