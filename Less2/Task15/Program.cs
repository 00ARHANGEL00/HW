// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.Write("Введите цифру обозначающую день недели: ");
int dayOfWeek = int.Parse(Console.ReadLine()!);

if (dayOfWeek < 1 || dayOfWeek > 7) Console.WriteLine("Нет дня недели с данным номером!");
else if(dayOfWeek == 6 || dayOfWeek == 7) Console.WriteLine("Да, это выходной день");
else Console.WriteLine("Нет, это рабочий день");