// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int  SumNumbers (int n)
{
    if (n%10 == 0) return n;
    else 
        return (n%10 + SumNumbers (n/10));
}
Console.WriteLine(SumNumbers(53271));
