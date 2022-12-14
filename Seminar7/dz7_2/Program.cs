// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> такой позиции в массиве нет

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = new Random().Next(1, 11); // [1, 10]
                    Console.Write($"{matrix[i, j]} \t");
                }
            Console.WriteLine();
        }
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
string[] numbers = Console.ReadLine().Split(" ");
int[,] matrix = new int[int.Parse(numbers[0]), int.Parse(numbers[1])];
int n_rows = int.Parse(numbers[0]);
int n_cols = int.Parse(numbers[1]);
Console.WriteLine("Двумерный массив: ");
InputMatrix(matrix);
Console.WriteLine();

Console.Write("Введите позицию элемента матрицы: ");
string[] points = Console.ReadLine().Split(" ");
int p_rows = int.Parse(points[0]);
int p_cols = int.Parse(points[1]);

if (p_rows > n_rows | p_cols > n_cols)
{
    Console.WriteLine("Такой позиции в массиве нет");
}
else
{
    Console.WriteLine($"Позиция соответствует значению: {matrix[p_rows, p_cols]}");
}