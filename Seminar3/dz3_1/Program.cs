// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел

int n10000 = n / 10000;
int n1000 = (n - (n10000 * 10000)) / 1000;
int n100 = (n - (n10000 * 10000) - (n1000 * 1000)) / 100;
int n10 = (n - (n10000 * 10000) - (n1000 * 1000) - (n100 * 100)) / 10;
int n1 = n % 10;
// 23432 -> да
int new_n = (n1 * 10000) + (n10 * 1000) + (n100 * 100) + (n1000 * 10) + n10000;
// Console.WriteLine(n10000);
// Console.WriteLine(n1000);
// Console.WriteLine(n100);
// Console.WriteLine(n10);
// Console.WriteLine(n1);
// Console.WriteLine(new_n);

if (n == new_n)
{
    Console.WriteLine($"Введенное число {n} является палиндромом");
}
else
{
    Console.WriteLine($"Введенное число {n} не является палиндромом");
}