// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. 

/*int num = new Random().Next(10, 99);
int s1 = num / 10;
int s2 = num % 10;

Console.WriteLine(num);
Console.WriteLine(s1+" "+s2);

if (s1 > s2) Console.WriteLine(s1);
else Console.WriteLine(s2);
*/


const int N = 12;
int[] a = new int[N];

Random rnd = new Random();
int positive = 0;
int negative = 0;

for (int i = 0; i < N; i++)
{
    int value;
    do
    {
        value = rnd.Next(-10, 10);
    } while (value == 0 ||
              (value < 0 && negative == (N + 1) / 2) ||
              (value > 0 && positive == (N + 1) / 2));

    if ( value < 0 ) ++negative;
    else ++positive;

    a[i] = value;
}

foreach (int x in a) Console.Write("{0} ", x);
Console.WriteLine();