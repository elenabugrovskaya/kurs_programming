// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа. 

int num = new Random().Next(10, 99);
int s1 = num / 10;
int s2 = num % 10;

Console.WriteLine(num);

if (s1 > s2) Console.WriteLine(s1);
else Console.WriteLine(s2);
