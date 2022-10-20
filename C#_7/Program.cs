// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа. 

int num = new Random().Next(10, 999);

Console.WriteLine(num);

int result = (num / 100) * 10 + num % 10;

Console.WriteLine(result);