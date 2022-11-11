// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

void FillMas (int[,] arr)
{
    for (int i=0; i<5;i++)
    for (int j=0; j<5; j++)
    arr[i, j] = new Random().Next(2, 10);
}
void Output (int [,] arr)
{
    for (int i=0; i<arr.GetLength(0); i++)
    {
        for (int j=0; j<arr.GetLength(1); j++)
        Console.Write(arr[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int [,] Swap (int [,] arr)
{
    int LastIndex = arr.GetLength(0) - 1;
    for (int j=0; j<arr.GetLength(1); j++)
    {
        int temp = arr[0, j];
        arr[0, j] = arr[LastIndex, j];
        arr[LastIndex, j] = temp; 
    }
    return arr;
}
int [,] array = new int [5, 5];
FillMas(array);
Output(array);
int [,] newArr = new int [5, 5];
newArr = Swap(array);
Output(newArr);
