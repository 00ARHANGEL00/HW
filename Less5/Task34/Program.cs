// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int[] GetArray(int n, int minVal, int maxVal)
{
    int[] res = new int[n];
    for (int i = 0; i < n; i++) res[i] = new Random().Next(minVal, maxVal + 1);
    return res;
}

int CountEvenNumber(int[] arr)
{
    int count = 0;
    foreach (int el in arr){
        if (el % 2 == 0) count ++;
    }
    return count;
}

int[] array = GetArray(10, 100, 999);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Количество чётных чисел в массиве: {CountEvenNumber(array)}");