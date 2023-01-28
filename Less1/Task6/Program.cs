// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if (num % 2 == 0)
    Console.WriteLine($"Число {num} - чётное!");
else
    Console.WriteLine($"Число {num} - нечётное!");