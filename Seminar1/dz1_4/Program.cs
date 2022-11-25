// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i} ");
    }
}