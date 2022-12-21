﻿// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void CreateArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
            array[i, j, k] = new Random().Next(10, 100); // [10, 99]
      }
    }
  }
}


void WriteArray (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write( $"{array[i,j,k]}({i},{j},{k}); ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

Console.Clear();
Console.Write("Введите размеры матрицы 3D: ");
string[] numbers = Console.ReadLine().Split(" ");

int[,,] array = new int[int.Parse(numbers[0]), int.Parse(numbers[1]), int.Parse(numbers[2])];
CreateArray(array);
WriteArray(array);