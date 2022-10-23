// Напишите програрамму, которая по заданному номеру четверти, показывает возможный диапазон координат точек в этой четверти (x, y).

void diapason (int a)
{
    if (a == 1) Console.WriteLine("x > 0 и y > 0");
    else if (a == 2) Console.WriteLine("x < 0 и y > 0");
    else if (a == 3) Console.WriteLine("x < 0 и y < 0");
    else Console.WriteLine("x > 0 и y < 0");
}
int a = int.Parse(Console.ReadLine());
diapason (a);
