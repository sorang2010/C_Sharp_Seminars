// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
Console.Write("Сколько чисел будете вводить: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] a1 = new int[]{};


for (int i = 1; i <=n; i++)
{
    Console.Write("Введите число : ");
    int num_a1 = Convert.ToInt32(Console.ReadLine()); // ввод чисел
    a1 = a1.Append(num_a1).ToArray();
}

Console.WriteLine($"Введенные числа: [{string.Join(", ", a1)}]");

int count = 0;
for (int j = 0; j < a1.Length; j++)
{
if (a1[j] > 0)
    count++;
}

string num1 = "число";
string num234 = "числа";
string num5x = "чисел";

if (count == 1)
{
    Console.WriteLine($"Введено {count} {num1} больше 0");
}
else if (count == 2 | count == 3 | count == 4)
{
    Console.WriteLine($"Введено {count} {num234} больше 0");
}
else
{
    Console.WriteLine($"Введено {count} {num5x} больше 0");
}