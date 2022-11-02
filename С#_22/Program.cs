// Перевести десятичное число в двоичное

int number = int.Parse(Console.ReadLine());
int osn = 16;
string number_2 = Convert.ToString(number, 16); //2, 8, 16, 32

Console.WriteLine(number_2);
Console.WriteLine(perevod(number, osn));

string perevod (int number, int osn)
{
    string res = " ";
    string nums = "0123456789ABCDEF";
    while (number > 0)
    {
        //int del = number/osn;
        //res = nums[number - del*osn] + res;
        res = nums[number%osn]+res;
        number /= osn;
    }
    return res;
}
