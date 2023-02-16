// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

int PositiveCol(double[] arr)
{
    int col = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) col++;
    }
    return col;
}

double[] GetArrray(int n)
{
    double[] res = new double[n];
    for (int i = 0; i < n; i++)
    {
        res[i] = double.Parse(Console.ReadLine()!);
    }
    return res;
}

Console.Write("Введите сколько чисел хотите ввести: ");
int n = int.Parse(Console.ReadLine()!);
if (n <= 0)
{
    Console.WriteLine("Количество чисел не может быть отрицательным!");
}
else
{
    Console.WriteLine("Введите числа(через Enter):");
    double[] nums = GetArrray(n);

    Console.WriteLine($"Чисел больше нуля: {PositiveCol(nums)}");
}
