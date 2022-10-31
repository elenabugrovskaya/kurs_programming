/* Создать массив, заполнить рандомными числами и вывести. конвертировать в список т добавить 7 в начало.
*/

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
void CreateList(List<int> numb)
{
    for (int i=0; i<10; i++)
    numb.Add(new Random().Next(2, 10));
}
List<int> numbers = new List<int> ();
int[] array = new int[10];
array =CreateMas(10);
Print (array);
array.ToList();
CreateList(numbers);
foreach (var n in numbers)
{
    Console.Write(n + " ");
} 
 Console.Write("\n");
numbers.AddRange(array);
foreach (var n in numbers)
{
    Console.Write(n + " ");
} 