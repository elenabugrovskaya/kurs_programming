// По данным числам n x m заполните двумерный массив размером n x m " змейкой", как показано в примере. Вводятся 2 числа n x m.
// Чтобы сделать такой большой отступ можно использовать \t.

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
        Console.Write(mylist[i][j] + "\t");
        Console.WriteLine();
    }
     Console.WriteLine();
}
void Zapolnenie (List<List<double>> mylist)
{   
    double count = 1;
    for(int i=0; i<5; i++)
    {
        for(int j=0; j<5; j++)
        {
            mylist[i][j] = count;
            count++;
    }
        }
        
  
}

List<List<double>> numbers = new List<List<double>>();
FillList(numbers);
PrintList(numbers); 
Zapolnenie(numbers); 
PrintList(numbers); 


