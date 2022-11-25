// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел

if (n % 2 == 0)
{
    Console.WriteLine($"{n} - четное число");
}

else
{
    Console.WriteLine($"{n} - нечетное число");
}
