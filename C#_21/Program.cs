// N кеглей выставили в один ряд, занумеровав их слева направо числами от 1 до N. Затем по этому ряду бросили K шаров, при 
// этом i-й шар сбил все кегли с номерами от li до ri включительно. Определите, какие кегли остались стоять на месте.
// Программа получает на вход количество кеглей N и количество бросков K. Далее идет K пар чисел li, ri, при этом 1≤ li≤ ri≤ N.

//Программа должна вывести последовательность из N символов, где j-й символ есть “I”, если j-я кегля осталась стоять, или “.”, если j-я кегля была сбита.

void Print(string[] arr)
{
    Console.WriteLine(String.Join(" ", arr));
    Console.Write("\n");
}
string[] Sbitie (string[] arr, int k)
{
    for (int i=0; i<k; i++)
    {
            Console.Write("Введите от ");
            int l1 = int.Parse(Console.ReadLine());
            Console.Write("Введите до ");
            int r1 = int.Parse(Console.ReadLine());
            for (int j = l1; j < r1+1; j++)
            {
                arr[j-1]=".";
            }
    }
        return arr;
}

Console.Write("Введите количество кеглей: ");
int N = int.Parse(Console.ReadLine());
string[] nums = new String[N];
for (int i=0; i<nums.Length; i++)
{
    nums[i] = "I";
}
Print(nums);
Console.Write("Введите количество бросков: ");
int k = int.Parse(Console.ReadLine());
nums = Sbitie(nums, k);
Print(nums);
