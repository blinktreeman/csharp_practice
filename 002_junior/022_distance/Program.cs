// Найти расстояние между точками в пространстве 2D/3D

Console.WriteLine("Введите координаты двух точек в пространстве");
Console.WriteLine("Точка А с координатами (Xa, Ya, Za)");
Console.Write("Xa = ");
int xA = int.Parse(Console.ReadLine());
Console.Write("Ya = ");
int yA = int.Parse(Console.ReadLine());
Console.Write("Za = ");
int zA = int.Parse(Console.ReadLine());
Console.WriteLine("Точка B с координатами (Xb, Yb, Zb)");
Console.Write("Xb = ");
int xB = int.Parse(Console.ReadLine());
Console.Write("Yb = ");
int yB = int.Parse(Console.ReadLine());
Console.Write("Zb = ");
int zB = int.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
// Длина вектора в пространстве - квадратный корень из суммы квадратов расстояний по осям.

Console.WriteLine("Расстояние между точками равно " + distance);
