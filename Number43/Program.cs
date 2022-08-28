// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k1");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double Coordinate1(double b1, double k1, double b2, double k2)
{
    return Math.Round(((b2 - b1) / (k1 - k2)), 2);
}
double Coordinate2(double b1, double k1, double b2, double k2)
{
    return Math.Round(((k2 * (b2 - b1) / (k1 - k2)) + b2), 2);
}

if (k1 == k2 && b1 == b2) Console.WriteLine($"Вы задали две одинаковые прямые");
else if (k1 == k2 && b1 != b2) Console.WriteLine($"Прямые параллельны");
else
{
Console.Write($"Прямые пересекаются в точке ({Coordinate1(b1, k1, b2, k2)}; ");
Console.Write($"{Coordinate2(b1, k1, b2, k2)})");
}