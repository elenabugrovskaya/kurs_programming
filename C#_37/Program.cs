// Задайте значения M и N. Напишите программу, которая выдедет все натуральные числа в промежутке от M до N.
// M =2, N =5 -> "2, 3, 4, 5"

string FillNumbers (int m, int n)
{
    if (m == n) return (m).ToString();
    else 
        return (m + " " + FillNumbers(m+1, n));
}
Console.WriteLine(FillNumbers(2, 8));


