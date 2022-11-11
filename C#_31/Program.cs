// Дан двумерный массив и два числа: i и j. Поменяйте в массиве столбцы с номерами i и j и выведите результат.


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
void Swap (List<List<double>> mylist, int j1, int j2)
{   
    double temp = 0;
    for(int i=0; i<mylist.Count; i++)
    for(int j=0; j<mylist[i].Count; j++)
    {
        temp = mylist[i][j1];
        mylist[i][j1] = mylist[i][j2];
        mylist[i][j2] = temp;
    }
}
List<List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers); 
Swap(numbers, 1, 2); 
PrintList(numbers); 
