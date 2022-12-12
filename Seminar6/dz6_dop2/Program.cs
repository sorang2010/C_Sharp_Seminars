// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) требуется вычислить его площадь. 
Console.Clear();
Console.Write("Вершина 1 треугольника. Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вершина 1 треугольника. Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вершина 2 треугольника. Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вершина 2 треугольника. Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вершина 3 треугольника. Введите координату x3: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Вершина 3 треугольника. Введите координату y3: ");
int y3 = Convert.ToInt32(Console.ReadLine());

double Sq = 0.5*((x1-x3)*(y2-y3)-(x2-x3)*(y1-y3));

Console.WriteLine($"Площадь треугольника: {Math.Abs(Sq)}");