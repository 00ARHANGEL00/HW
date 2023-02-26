// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

int Sum(int m, int n)
{
    if (m == n) return m;
    else return n + Sum(m, n - 1);
}

Console.Write("Веведите M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Веведите N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма последовательности от M до N равна {Sum(m, n)}");