// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Например
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Решение дома 

// Console.WriteLine("Введите координаты трех точек");
// Console.Write("XA: ");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.Write("YA: ");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.Write("ZA: ");
// int za = Convert.ToInt32(Console.ReadLine());
// Console.Write("XB: ");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.Write("YB: ");
// int yb = Convert.ToInt32(Console.ReadLine());
// Console.Write("ZB: ");
// int zb = Convert.ToInt32(Console.ReadLine());

// double result = Distance(xa, ya, za, xb, yb, zb);
// Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero));

// double Distance(double xa1, double ya1, double za1, double xb2, double yb2, double zb2)
// {
//     double dotX = Math.Pow((xb2 - xa1), 2);
//     double dotY = Math.Pow((yb2 - ya1), 2);
//     double dotZ = Math.Pow((zb2 - za1), 2);
//     double result = Math.Sqrt(dotX + dotY + dotZ);
//     return result;
// }

// Решение как на семинаре.

Console.WriteLine("Введите координаты трех точек");
Console.Write("XA: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("YA: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("ZA: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("XB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("YB: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("ZB: ");
int zb = Convert.ToInt32(Console.ReadLine());

double ourDistance =  Math.Round(Distance(xa, xb, ya, yb, za, zb), 2, MidpointRounding.ToZero);
Console.WriteLine($"Растояние между точками в 3D пространстве равно -> {ourDistance}.");

double Distance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return distance;
}
