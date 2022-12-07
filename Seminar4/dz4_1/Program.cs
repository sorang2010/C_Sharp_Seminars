// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// НЕ ИСПОЛЬЗОВАТЬ MATH.POW
int numberUP(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= a; // result = result * i
    }
    return result;
}

Console.Clear();
Console.Write("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 в степень которого возвести число 1: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат: {numberUP(a, n)}");