// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз 
// встречается элемент входных данных.
// 1 2 3    1 - встречается 2 раза 
// 4 5 6    2 - встречается 1 раз и т.д.
// 7 1 9

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
int[] GetArray (int [,] array)
{
    int[] ArrayOne = new int[array.GetLength(0)*array.GetLength(1)];
    int k = 0;
     for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
        {
            ArrayOne[k] = array[i, j];
            k++;
        }
        PrintMasOne(ArrayOne);
        return ArrayOne;
}
void PrintMasOne(int[] array)
{
    foreach (var el in array)
        {
          Console.Write(el + " ");  
        }
        Console.WriteLine();  
}
void SortMas (int[] array)
{ 
 for (int i=0; i<array.Length-1; i++)
 {
        for (int j=i+1; j<array.Length; j++)  
        if(array[i]>array[j])
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        } 
 }
        PrintMasOne(array);
 
}

void FillDictionary(int[,] array)
{
    Dictionary<int, int> numbers = new Dictionary<int, int>();
    for (int i=0; i<array.GetLength(0); i++)
        for (int j=0; j<array.GetLength(1); j++)
        {
            if(numbers.ContainsKey(array[i, j]))
            numbers[array[i,j]] += 1;
            else
            numbers.Add(array[i, j], 1);
        }    
    foreach (var num in numbers)
        {
          Console.WriteLine($"Число {num.Key}  встретилось {num.Value} ");  
        }
        
}
int [,] array = new int [5, 5];
FillMas(array);
int [,] newArr = new int [5, 5];
newArr = Swap(array);
Output(newArr);
//int[] arr1 = GetArray(newArr);
//SortMas(arr1);
FillDictionary(newArr);

