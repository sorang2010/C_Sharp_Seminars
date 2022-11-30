// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Вариант1
Console.Clear();
Console.Write("Введите число (например 123454321): ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел

int old_n = n;

int[] a1 = new int[]{};  // кол-во единиц, десятков, сотен...
int[] a2 = new int[]{};  // единицы, десятки, сотни...
int d = 1;
int i = 0;

while (old_n != 0)
{
    a2 = a2.Append(d).ToArray();
    // Console.WriteLine(a2[i]);
    int count_n = old_n % 10;
    a1 = a1.Append(count_n).ToArray();
    // Console.WriteLine(a1[i]);
    int x = old_n - count_n;
    old_n = x / 10;
    d = d * 10;
    i++;
}

Array.Reverse(a2);

int l_array = a1.Length; // a1 = a2
int new_n = 0;

for (int j = 0; j < l_array; j++)
{
    new_n = new_n + (a1[j] * a2[j]);
    // Console.WriteLine(new_n);
}

if (n == new_n)
{
    Console.WriteLine($"Введенное число {n} является палиндромом");
}
else
{
    Console.WriteLine($"Введенное число {n} не является палиндромом");
}