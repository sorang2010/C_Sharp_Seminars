// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 11); // [1, 10]
    }
  }
}


void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}


void MultiplyMatrix(int[,] a1, int[,] a2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < a1.GetLength(1); k++)
      {
        sum += a1[i,k] * a2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}


Console.Clear();
Console.Write("Введите размеры матрицы 1: ");
string[] numbers1 = Console.ReadLine().Split(" ");

int[,] a1 = new int[int.Parse(numbers1[0]), int.Parse(numbers1[1])];
CreateArray(a1);
WriteArray(a1);

Console.Write("Введите размеры матрицы 2: ");
string[] numbers2 = Console.ReadLine().Split(" ");

int[,] a2 = new int[int.Parse(numbers2[0]), int.Parse(numbers2[1])];
CreateArray(a2);
WriteArray(a2);

int[,] resultMatrix = new int[int.Parse(numbers1[0]), int.Parse(numbers1[1])];

MultiplyMatrix(a1, a2, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);