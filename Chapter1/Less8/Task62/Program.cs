// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.(Произвольный массив)

Console.Clear();

void FillArray(string[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    int count = 1;                  // Итератор для последовательности чисел.
    int time = 1;                   // Отступ от границы массива.
    int iter = 1;                   // Кол-во поворотов(iter-1).
    int end = n - 1;               // Конец заполнения.
    int endT = m - 1;              // Размр другой грани.
    int i = 0;                      // Начало заполнения.
    int j = 0;                      // По какой строке или столбцу идет заполнение.
    bool isReverse = false;         // Прямой проход.
    string temp;
    int tempIter = 0;               // Нужен для определения j.

    while (count <= m * n)
    {
        while (true)
        {
            temp = count < 10 ? "0" + count.ToString() : count.ToString();
            if (iter % 2 == 0) array[i, j] = temp;
            else array[j, i] = temp;
            count++;
            if (isReverse)
            {
                i--;
                if (i < iter / 4) break;
            }
            else
            {
                i++;
                if (i > end - iter / 4) break;
            }
        }
        if (iter % 2 == 0)
        {
            isReverse = !isReverse;
            end = n - 1;
            endT = m - 1;
        }
        else
        {
            end = m - 1;
            endT = n - 1;
        }
        if (isReverse) i = end - time;
        else
        {
            if (iter != 1 && (iter - 1) % 4 == 0) time++;
            i = time;
        }
        if (tempIter < 2) j = endT - iter / 4;
        else j = iter / 4;
        tempIter++;
        if (tempIter == 4) tempIter = 0;
        iter++;
    }
}

void PrintArray(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine()!);

string[,] arr = new string[m, n];
FillArray(arr);
PrintArray(arr);
