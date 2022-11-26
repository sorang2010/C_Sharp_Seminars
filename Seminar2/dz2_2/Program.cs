// Задача 13: Напишите программу, которая выводит третью цифру(c начала) заданного числа или сообщает, что третьей цифры нет.
// НЕ ИСПОЛЬЗОВАТЬ НУМЕРАЦИЮ СТРОК
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
int[] a1 = new int[]{};

if (n / 100 == 0)
{
    Console.Write("третьей цифры нет");
}
else
{
    // int n100 = n / 100;
    // int n10 = (n - (n100 * 100)) / 10;
    // Console.Write(n100);
    while (n / 10 != 0)
    {
        n = n / 10;
        a1 = a1.Append(n).ToArray();
        Console.WriteLine(a1);
        Console.WriteLine(n);
    }
    Array.Reverse(a1);
    Console.WriteLine(a1[2]);
    int x = a1[2] % 10;
    Console.WriteLine(x);
}