// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел

int[] a1 = new int[]{};

while (n != 0)
{
    int count_n = n % 10;
    a1 = a1.Append(count_n).ToArray();
    // Console.WriteLine(a1);
    int x = n - count_n;
    n = x / 10;
}

int l_array = a1.Length;
int sum_n = 0;

for (int j = 0; j < l_array; j++)
{
    sum_n = sum_n + a1[j];
}
Console.WriteLine(sum_n);