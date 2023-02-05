// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);

if (num < 10000 || num >= 100000)
    Console.WriteLine($"Это не пятизначное число!");
else
{
    int b = num / 1000, e = num % 100;
    if ((b / 10 == e % 10) && (b % 10 % 10 == e / 10))
        Console.WriteLine("Да, оно является палиндромом");
    else
        Console.WriteLine("Нет");    
}