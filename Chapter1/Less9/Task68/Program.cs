// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.Clear();

int СalculatingAckerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return СalculatingAckerman(m - 1, 1);
    else return СalculatingAckerman(m - 1, СalculatingAckerman(m, n - 1));
}

Console.Write("Веведите M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Веведите N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"A({m},{n}) = {СalculatingAckerman(m, n)}");