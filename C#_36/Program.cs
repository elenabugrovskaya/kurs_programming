// Залайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. С помощью рекурсии.
// n = 5 -> "1, 2, 3, 4, 5"

int k = 0;
string FillNumbers (int n)
{
    if (n == 1) return (k+1).ToString();
    else 
    {
        k++; 
        return (k + " " + FillNumbers(n-1));
    }
}
Console.WriteLine(FillNumbers(5));
