// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

int[] GetArray(int n, int minVal, int maxVal)
{
    int[] res = new int[n];
    for (int i = 0; i < n; i++) res[i] = new Random().Next(minVal, maxVal + 1);
    return res;
}

int SumNotEvenPosition(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) sum += arr[i];
    }
    // Альтернатива
    // for (int i = 1; i < arr.Length; i += 2)
    // {
    //     sum += arr[i];
    // }
    return sum;
}

int[] array = GetArray(6, 1, 99);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {SumNotEvenPosition(array)}");