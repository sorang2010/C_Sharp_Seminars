﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите цифру, обозначающую день недели (1 - 7): ");
int n = Convert.ToInt32(Console.ReadLine()); // ввод чисел
if (n <= 5)
{
    Console.Write("День будний");
}
else
{
    Console.Write("День выходной");
}