// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой 
// длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a+b>c && a+c>b && b+c>a)
Console.WriteLine("Да");
else Console.WriteLine("Нет");
