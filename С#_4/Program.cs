Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int M = -N;
while (M!=N) 
{
    Console.Write($"{M} ");
    M++;
}
Console.Write(M);
