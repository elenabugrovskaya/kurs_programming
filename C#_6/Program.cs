// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. 
int num = new Random().Next(10, 9999);
int max = num % 10;

Console.WriteLine(num);

while (num != 0)
{
    int k = num % 10;
    if (k > max) max = k;
    num = num / 10;
}
Console.WriteLine(max);
