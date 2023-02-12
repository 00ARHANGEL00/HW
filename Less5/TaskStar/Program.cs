// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сортировку.

Console.Clear();

int[] GetArray(int n, int minVal, int maxVal)
{
    int[] res = new int[n];
    for (int i = 0; i < n; i++) res[i] = new Random().Next(minVal, maxVal + 1);
    return res;
}

void BubbleSorting(int[] arr)
{
    int temp;
    for (int i = 1; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - i; j++)
        {
            if (arr[j] < arr[j + 1]){
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

int[] array = GetArray(10, -5, 10);
Console.WriteLine(String.Join(", ", array));
BubbleSorting(array);
Console.WriteLine($"Отсортированный массив: {String.Join(", ", array)}");