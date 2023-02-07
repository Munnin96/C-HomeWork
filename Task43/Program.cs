// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double ResultX(double b1, double k1, double b2, double k2)
{
    double x = 0;
    x = (-b2 + b1) / (-k1 + k2);
    x = Math.Round(x, 1);
    return x;
   
}
double ResultY(double b1, double k1, double b2, double k2)
{
    double x = CrossX(b1, k1, b2, k2);
    double y = 0;
    y = k2 * x + b2;
    y = Math.Round(y, 1);
    return y;
   
}
double X = ResultX(b1, k1, b2, k2);
double Y = ResultY(b1, k1, b2, k2);
Console.WriteLine($"две прямые пересекутся в точке с координатами X: {X}, Y: {Y}");