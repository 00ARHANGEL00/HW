// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер строки: ");
int numRow = int.Parse(Console.ReadLine()!) - 1;
Console.Write("Введите номер столбца: ");
int numColumn = int.Parse(Console.ReadLine()!) - 1;

int[,] arr = GetArray(rows, cols, 0, 10);
PrintArray(arr);

if (numRow < 0 || numColumn < 0) Console.WriteLine("Невалидные данные! Номера строки и столбца начинаются с 1.");
else if (numRow >= rows || numColumn >= cols) Console.WriteLine("Такого числа в массиве нет.");
else Console.WriteLine(arr[numRow, numColumn]);