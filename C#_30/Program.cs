// Задайте двумерный массивю Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты.

void FillList(List<List<double>> mylist)
{
    for(int i=0; i<5; i++)
    {
        mylist.Add(new List<double>());
        for(int j=0; j<5; j++)
        mylist[i].Add(Math.Round(new Random().NextDouble()*5));
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
double Zapolnenie (List<List<double>> mylist)
{   
    double sum = 0;
    for(int i=0; i<5; i++)
    {
        for(int j=0; j<5; j++)
        if(i == j)
        sum += mylist[i][j];
    }
    return sum;
}
List<List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers); 
Console.WriteLine(Zapolnenie(numbers)); 
PrintList(numbers); 



