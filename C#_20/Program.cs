// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int[] CreateMas (int n)
{
    int[] arr = new int[n];
    for (int i=0; i<n; i++)
    arr[i] = new Random().Next(2, 10);
    return arr; 
} 
void Print(int[] arr)
{
    Console.WriteLine(String.Join(" ", arr));
    Console.Write("\n");
}
void Poisk (int[] arr, int k)
{
    bool f = false;
     for (int i=0; i<arr.Length; i++)
     if (arr[i] == k)
     {
        f = true;
        break;
     }
     if (f)
     Console.WriteLine("Да, найден!");
     else
     Console.WriteLine("Нет, не найден!");
}
int[] array = new int[10];
array = CreateMas(10);
Print(array);
List<int> numbers = new List<int>();
numbers.AddRange(array);
bool b = numbers.Contains(5);
Console.WriteLine(b);
Poisk(array, 5);
