// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void StartArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(100, 1000); // [100, 999]
}


int NumEvens(int[] array)
{
int countEven = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
countEven++;
}
return countEven;
}


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
StartArray(array);
Console.WriteLine($"Заданный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Количество чётных чисел в массиве: {NumEvens(array)}");
