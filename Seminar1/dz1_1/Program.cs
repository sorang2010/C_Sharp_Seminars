//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine()); // ввод чисел
Console.Write("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine()); // ввод чисел

if (a < b)
{
    Console.WriteLine($"{a} меньше {b}");
}
else if (a > b)
{
    Console.WriteLine($"{a} больше {b}");
}
else
{
    Console.WriteLine($"{a} равно {b}");
}