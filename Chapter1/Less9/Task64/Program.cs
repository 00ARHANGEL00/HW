// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

Console.Clear();

string CreateSequence(int n)
{
    if (n == 1) return n.ToString();
    else return n.ToString() + ", " + CreateSequence(n - 1);
}

Console.Write("Веведите число: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(CreateSequence(n));