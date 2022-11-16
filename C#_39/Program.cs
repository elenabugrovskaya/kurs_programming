// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 2, B = 3 -> 8

int  Stepen (int A, int B)
{
    if (B == 0) return 1;
    if (B == 1) return A;
    else 
    B--;
    return (A*Stepen(A, B));
}
Console.WriteLine(Stepen(2, 3));
