// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


Dictionary<string, int> SetParametrsTwoLines()
// The method sets parameters for two straight lines

{
    Dictionary<string, int> ParametrsLines = new Dictionary<string, int>()
    {
        { "k1", 0},
        { "b1", 0},
        { "k2", 0},
        { "b2", 0},
    };

    foreach (var (key, value) in ParametrsLines)
    {
        Console.Write($"Задайте параметр {key}: ");
        try {ParametrsLines[key] = Convert.ToInt32(Console.ReadLine());}
        catch
        {
            Console.Write("Некорректный ввод, введите целое число: ");
            ParametrsLines[key] = Convert.ToInt32(Console.ReadLine());
        }
    }
    Console.WriteLine("Получены следующие значения:");
    foreach (var (key, value) in ParametrsLines) {Console.WriteLine($"{key} - {value}");}
    return ParametrsLines;
}

void DefineIntersectionPoint(Dictionary<string, int> parametrs)
// The method determines the intersection point of two straight lines
{
    if ((parametrs["k1"] == parametrs["k2"]) && (parametrs["b1"] == parametrs["b2"])) Console.WriteLine("Прямые совпадают");
    else if (parametrs["k1"] == parametrs["k2"]) Console.WriteLine("Прямые параллельны");
    else
    {
        var PointX = -(parametrs["b1"] - parametrs["b2"]) / (parametrs["k1"] - parametrs["k2"]);
        var PointY = parametrs["k1"] * PointX + parametrs["b1"];
        Console.WriteLine($"Прямые пересекаются в точке со значениями х - {PointX}, y - {PointY}");
    }
}

Dictionary<string, int> UserParametrs = SetParametrsTwoLines();
DefineIntersectionPoint(UserParametrs);
