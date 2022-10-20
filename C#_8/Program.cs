// 
Console.Write("Введите 1 число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите 2 число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 % num2 == 0)
Console.WriteLine("Кратно");

else Console.WriteLine($"Не кратно, остаток от деления равен {num1 % num2}");
