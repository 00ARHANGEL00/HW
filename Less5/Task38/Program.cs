// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

double[] GetArray(int n, int minVal, int maxVal)
{
    double[] res = new double[n];
    for (int i = 0; i < n; i++) res[i] = Math.Round(minVal + (maxVal - minVal) * (new Random().NextDouble()), 2);
    return res;
}

double FindMin(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
    }
    return min;
}

double FindMax(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
    }
    return max;
}

double[] array = GetArray(10, 1, 100);
double max = FindMax(array), min = FindMin(array);

Console.WriteLine(String.Join("; ", array));
Console.WriteLine($"Максимальный элемент: {max}, минимальный элемент: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементов массива равна {max - min}");