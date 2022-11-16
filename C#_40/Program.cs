// "Словарь синонимов" Вам дан словарь, состоящий из пар слов, каждое слово является синонимом к парному ему слову. Все слова
// в словаре различны. Для слова из словаря, записанного в последней строке, определите его синоним.

string FindDictionary (int n)
{
    Dictionary <string, string> dict = new Dictionary<string, string>();
    for (int i=0; i<n; i++)
    {
        Console.Write("Введите пары слов: ");
        string[] names = Console.ReadLine().split();
        dict.Add(names[0], names[1]);
        dict.Add(names[1], names[0]);
    }
    Console.Write ("Введите слово из коллекции: ");
    int kol = int.Parse(Console.ReadLine());
    Console.WriteLine(FindDictionary(kol));
}
Console.WriteLine(SumNumbers(4, 8));
