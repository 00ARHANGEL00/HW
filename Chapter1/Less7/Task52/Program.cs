// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

int[,] GetArray(int m, int n, int minVal, int maxVal)
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = new Random().Next(minVal, maxVal + 1);
        }
    }
    return arr;
}

void PrintArray(int[,] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] GetAvgColumns(int[,] array)
{
    double[] avg = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        avg[i] = Math.Round((double)sum / array.GetLength(0), 2);
    }
    return avg;
}

Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

int[,] arr = GetArray(rows, cols, 0, 10);
PrintArray(arr);

double[] arrayAvg = GetAvgColumns(arr);
Console.WriteLine(string.Join("; ", arrayAvg));