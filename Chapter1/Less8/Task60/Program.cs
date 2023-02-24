// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();

int[,,] GetArray(int m, int n, int z)
{
    int[,,] arr = new int[z, m, n];
    int iter = 10;
    for (int k = 0; k < z; k++)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[k, i, j] = iter++;
            }
        }
    }
    return arr;
}

void PrintArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                Console.Write($"{array[k, i, j]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int cols = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int depth = int.Parse(Console.ReadLine()!);

int[,,] arr = GetArray(rows, cols, depth);
PrintArray(arr);
