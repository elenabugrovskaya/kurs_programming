// Задайте двумерный массив размером  m x n, каждый элемент в массиве находится по формуле: A[m,n] = m+n.

void FillList(List<List<double>> mylist)
{
    for(int i=0; i<5; i++)
    {
        mylist.Add(new List<double>());
        for(int j=0; j<5; j++)
        mylist[i].Add(new Random().NextDouble()*5);
    }
}
void PrintList(List<List<double>> mylist)
{
    for(int i=0; i<mylist.Count; i++)
    {
        for(int j=0; j<mylist.Count; j++)
        Console.Write(mylist[i][j] + " ");
        Console.WriteLine();
    }
     Console.WriteLine();
}
void Zapolnenie (List<List<double>> mylist)
{
    for(int i=0; i<5; i++)
    {
        for(int j=0; j<5; j++)
        mylist[i][j] = i+j;
    }
}
List<List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers); 
Zapolnenie(numbers); 
PrintList(numbers); 
