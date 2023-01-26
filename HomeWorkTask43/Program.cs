// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// Например
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите координаты b1, k1, b1, b2");
Console.Write("b1 = ");
double b1 = Convert.ToUInt32(Console.ReadLine());
Console.Write("k1 = ");
double k1 = Convert.ToUInt32(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToUInt32(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToUInt32(Console.ReadLine());

double dotX = DotX(b1, k1, b2, k2);
double dotY = DotY(b1, k1, b2, k2);
Console.WriteLine();
Console.WriteLine($"b1 = {b1} k1 = {k1} b2 = {b2} k2 = {k2} -> Точка X {dotX}, Точка Y {dotY}.");

double DotX(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    x = Math.Round(x, 1);
    return x;
}

double DotY(double b1, double k1, double b2, double k2)
{
    double point = DotX(b1, k1, b2, k2);
    double y = k1 * point + b1;
    y = Math.Round(y, 1);
    return y;
}