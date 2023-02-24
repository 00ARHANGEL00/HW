// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int FindMinRow(int[,] array)
{
    int minRowIndex = 0;
    int sum;
    int sumMin = int.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sumMin > sum)
        {
            minRowIndex = i + 1;
            sumMin = sum;
        }
    }
    return minRowIndex;
}

Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);

if (rows == cols) Console.WriteLine("Матрица должна быть прямоугольной!");
else
{
    int[,] arr = GetArray(rows, cols, 0, 10);
    PrintArray(arr);

    int minRow = FindMinRow(arr);
    Console.WriteLine($"{minRow} строка");
}
