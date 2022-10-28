// Задан список брокеров товарной биржи из N человек. Обменяйте местами фамилии брокеров: первого и последнего, 
// второго и предпоследнего, третьего от начала и третьего от конца и т.д
// Олег Вася Камилла -> Камилла Вася Олег

void Vivod(string[] arr)
{
    foreach (var i in arr)
    Console.Write(i + " ");
    Console.WriteLine();
}

string[] Perestanovka(string[] arr)
{
    for (int i=0; i<arr.Length/2; i++)
    {
        string t = arr[i];
        arr[i] = arr[arr.Length-1];
        arr[arr.Length-1] = t;
    }
    return arr;
}
int N = int.Parse(Console.ReadLine());
string[] names = new string[N];
for (int i=0; i<N; i++)
names[i] = Console.ReadLine();

Vivod (names);
Perestanovka (names);
Vivod (names);

