// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, предоставить возможность пользователю ввести числа и вывести их на экран.
Console.Clear();
int[] a1 = new int[8];
for (int i = 0; i < 8; i++)
{
    Console.Write($"Введите число {i + 1} из 8: ");
    int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел

    a1[i] = n;
}

Console.WriteLine($"Результат: [{string.Join(", ", a1)}]");

