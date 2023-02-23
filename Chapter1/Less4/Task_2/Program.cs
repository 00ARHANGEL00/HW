// Написать программу вычисления произведения чисел от 1 до N.

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int mult = 1;
if (num < 1) mult = 0;
else
{
    for (int i = 1; i <= num; i++)
    {
        mult *= i;
    }
}

Console.WriteLine($"Произведение чисел равно {mult}");