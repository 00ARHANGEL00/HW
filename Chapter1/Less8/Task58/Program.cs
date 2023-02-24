// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

int[] GetSizeArray()
{
    int[] sizeArray = new int[2];
    Console.Write("Введите кол-во строк: ");
    sizeArray[0] = int.Parse(Console.ReadLine()!);
    Console.Write("Введите кол-во столбцов: ");
    sizeArray[1] = int.Parse(Console.ReadLine()!);
    return sizeArray;
}

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

int[,] ProductMatrix(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    int temp;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            temp = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                temp += array1[i, k] * array2[k, j];
            }
            result[i, j] = temp;
        }
    }
    return result;
}

int[] sizeArr1 = GetSizeArray();
int[] sizeArr2 = GetSizeArray();

if (sizeArr1[1] == sizeArr2[0])
{
    int[,] arr1 = GetArray(sizeArr1[0], sizeArr1[1], 0, 10);
    PrintArray(arr1);
    int[,] arr2 = GetArray(sizeArr2[0], sizeArr2[1], 0, 10);
    PrintArray(arr2);

    int[,] prodMatrix = ProductMatrix(arr1, arr2);
    System.Console.WriteLine("Результирующая матрица:");
    PrintArray(prodMatrix);
}
else Console.WriteLine("Произведение матриц невозможно!");
