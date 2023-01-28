// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 == num2)
    Console.WriteLine($"{num1} и {num2} равны между собой");
else if (num1 > num2)
    Console.WriteLine($"Максимальное: {num1}, а минимальное: {num2}");
else
    Console.WriteLine($"Максимальное: {num2}, а минимальное: {num1}");