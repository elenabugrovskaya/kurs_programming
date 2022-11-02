//  Не используя рекурсию, выведите первые N чисел Фибоначчи: 0 и 1.

int n = int.Parse(Console.ReadLine());
int first = 0;
int second = 1;
Console.Write(first + " " + second + " ");
for (int i = 3; i <= n; i++)
{
    int next = first + second;
    Console.Write(next + " ");
    first = second;
    second = next;
}
