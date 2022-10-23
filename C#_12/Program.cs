// Напишите программу, которая принимает на вход координаты 2 точек и находит  расстояние м/д ними в пространстве.


double dist (int x1, int y1, int x2, int y2)
{
    double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return res;
}
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());

double otvet = dist(x1,y1,x2,y2);
Console.WriteLine(otvet);
