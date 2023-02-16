// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

bool Validation(double[] k, double[] c)
{
    if (k[0] == k[1])
    {
        if (c[0] == c[1])
        {
            Console.WriteLine("Прямые лежат друг на друге, т.е. все точки совпадают между собой");
            return false;
        }
        else
        {
            Console.WriteLine("Прямые параллельны");
            return false;
        }
    }
    return true;
}

double[] FindCrossing(double[] k, double[] c)
{
    double[] res = new double[2];
    res[0] = (c[0] - c[1]) / (k[1] - k[0]);
    res[1] = k[0] * res[0] + c[0];
    return res;
}

double[] k = new double[2];
double[] c = new double[2];

for (int i = 0; i < 2; i++)
{
    Console.Write("Введите коэффициент прямой: ");
    k[i] = double.Parse(Console.ReadLine()!);

    Console.Write("Введите константу прямой: ");
    c[i] = double.Parse(Console.ReadLine()!);
}

if (Validation(k, c)){
    double[] cross = FindCrossing(k, c);
    Console.WriteLine($"Точка пересечения: x={cross[0]} и y={cross[1]}");
}
