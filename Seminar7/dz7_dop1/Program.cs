// Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали. 
void InputMatrix(int[,] matrix1)
{
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(-10, 11); // [-10, 10]
            Console.Write($"{matrix1[i, j]} \t");
        }
        Console.WriteLine();
}
}


void ReleaseMatrix(int[,] matrix2)
{
    int num_rows = matrix2.GetLength(0);
    int num_cols = matrix2.GetLength(1);
    int[,] tmp = new int[num_rows, num_cols];
    for (int i = 0; i < num_rows; i++)
    {
        for (int j = 0; j < num_cols; j++)
        {
            tmp[i, j] = matrix2[num_rows - i - 1, j];
            Console.Write($"{tmp[i, j]} \t");
        }
         Console.WriteLine();
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
