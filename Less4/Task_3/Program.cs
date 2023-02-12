// Показать кубы чисел, заканчивающихся на четную цифру. (сделал только для положительных чисел)

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

for (int i = 2; i <= num; i++)
{
    if (i % 2 == 0) Console.Write($"{i * i * i} ");
}