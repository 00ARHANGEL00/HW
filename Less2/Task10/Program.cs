// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.Write("Введите 3-x значное число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine(num / 10 % 10);