// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты

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
void Zapolnenie (List<List<double>> mylist)
{
    for(int i=0; i<5; i++)
    {
        for(int j=0; j<5; j++)
        if(i%2==0 && j%2==0)
        mylist[i][j] = Math.Pow(mylist[i][j], 2);
    }
}
List<List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers); 
Zapolnenie(numbers); 
PrintList(numbers); 

