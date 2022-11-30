// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
Console.Write("Введите координату X точки 1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки 1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки 1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X точки 2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y точки 2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z точки 2: ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)), 2));
