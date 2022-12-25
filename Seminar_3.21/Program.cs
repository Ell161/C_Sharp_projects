// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Dictionary<string, int> points = new Dictionary<string, int>();

for (int i = 1; i < 3; i++)
{
    Console.Write($"Введите координату х {i}-й точки: ");
    points.Add($"x{i}", Convert.ToInt32(Console.ReadLine()));
    Console.Write($"Введите координату y {i}-й точки: ");
    points.Add($"y{i}", Convert.ToInt32(Console.ReadLine()));
    Console.Write($"Введите координату z {i}-й точки: ");
    points.Add($"z{i}", Convert.ToInt32(Console.ReadLine()));
}

double distance = Math.Pow((Math.Pow(points["x2"] - points["x1"], 2) + Math.Pow(points["y2"] - points["y1"], 2) + Math.Pow(points["z2"] - points["z1"], 2) * 1.0), 0.5);
Console.WriteLine($"Расстояние между точками равно {distance}");