Console.Write("Введите 1 число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите 2 число: ");
int num2 = int.Parse(Console.ReadLine());
if (num2*num2 == num1)
    Console.WriteLine($"{num1} квадрат {num2}");
else
{
    Console.WriteLine("Первое число не является квадратом второго.");
}

