// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
void StartArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 101); // [1, 100]
}

int NumOdds(int[] array)
{
int SummOdds = 0;
for (int i = 1; i < array.Length; i+=2)
SummOdds += array[i];
return SummOdds;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
StartArray(array);
Console.WriteLine($"Заданный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов на нечётных позициях: {NumOdds(array)}");
