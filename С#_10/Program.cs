// Напишите программу, которая принимает на вход координаты точки (x,y), причем x!=0, y!=0 и выдает номер четверти плоскости,
// в которой находится эта точка. 

string chetvert(int x, int y)
{
    string name = x > 0 && y > 0 ? "1 четверть" : x < 0 && y > 0 ? "2 четверть" : x < 0 && y < 0 ? "3 четверть" : "4 четверть";
    return name;

}

int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

string otvet = chetvert(x, y);
Console.WriteLine(otvet);
