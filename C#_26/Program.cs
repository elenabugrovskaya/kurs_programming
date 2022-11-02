// Дано число N. Создайте массив размером n x n и заполните его по существующему правилу. На главной диагонали должны быть
// записаны числа 0. На двух диагоналях, прилегающих к главной, числа 1. На следующих двух диагоналях числа 2 и т.д.

int n = int.Parse(Console.ReadLine());
int[,] m = new int [n,n];
int cc = 1;

for (int i=0; i<m.GetLength(0); i++)
{
    for(int j=0; j<m.GetLength(1); j++)
    {
        if (i==j) m[i,j]=0;
        else if (j>i)
        {
            cc=j-i;
            m[i,j]=cc;
        }
        m[j,i]=m[i,j];
        Console.Write(m[i,j] + " ");
    }
Console.WriteLine();
}
