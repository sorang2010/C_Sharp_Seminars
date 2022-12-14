// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void InputMatrix(int[,] matrix1)
{
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix1[i, j]} \t");
        }
        Console.WriteLine();
}
}


void ReleaseMatrix(int[,] matrix2)
{
    int num_rows = matrix2.GetLength(0);
    int num_cols = matrix2.GetLength(1);

    for (int i = 0; i < num_rows; i++)
    {
        double summ = 0;
        for (int j = 0; j < num_cols; j++)
        {
            summ += matrix2[j, i];           
        }
        double sr_a = summ / num_rows;
        Console.Write($"{Math.Round(sr_a, 1)} \t");
     }
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
Console.WriteLine("Двумерный массив: ");
InputMatrix(matrix);

Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Результат: ");
ReleaseMatrix(matrix);

