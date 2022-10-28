// Программа должна создать массив из 12 случайных целых чисел из отрезка [-10;10] таким образом, чтобы отрицательных и
// положительных элементов там было поровну и не было нулей. При этом порядок следования элементов должен быть случаен 
// (т. е. не подходит вариант, когда в массиве постоянно выпадает сначала 6 положительных, а потом 6 отрицательных чисел или
// же когда элементы постоянно чередуются через один и пр.). Вывести полученный массив на экран.

int[] CreateMas()
{
    int kol = 12;
    int[] arr = new int[12];
    int kol_pol = 0;
    int kol_otr = 0;
    int kol_zero = 1;
    while (kol_pol !=6 && kol_otr !=6 && kol_zero != 0)
    {
        kol_pol = 0;
        kol_otr = 0;
        kol_zero = 0;
        for (int i = 0; i < kol; i++)
        {
            arr[i] = new Random().Next(-10, 10);
            if (arr[i] > 0) kol_pol++;
            else if (arr[i]< 0) kol_otr++;
            else kol_zero++;
        }
    }
    return arr;
}
void Print(int[] arr)
{
    Console.WriteLine(String.Join(" ", arr));
}
int[] arr = new int[12];
arr = CreateMas();
Print(arr);
