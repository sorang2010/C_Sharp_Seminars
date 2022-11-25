// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine()); // ввод чисел
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine()); // ввод чисел
Console.Write("Введите число 3: ");
int c = Convert.ToInt32(Console.ReadLine()); // ввод чисел

int max = a;

if (b > a)
{
    max = b;
}
if (b == a)
{
    max = a;
}
if (c > max)
{
    max = c;
}
if (c == a)
{
    max = a;
}

Console.WriteLine($"{max}");
