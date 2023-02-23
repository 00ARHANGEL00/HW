// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

double[,] GetArray(int m, int n, int minVal, int maxVal)
{
    double[,] arr = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = Math.Round(minVal + (maxVal - minVal) * (new Random().NextDouble()), 2);
        }
    }
    return arr;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);
double[,] arr = GetArray(rows, cols, 0, 10);
PrintArray(arr);
