// Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// Например
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Ведите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int digit1 = number / 10;
int digit2 = number % 10;
int digit3 = digit1 % 10;

if (number >= 10 && number <= 99)
{
Console.WriteLine("Ошибка число не является трехзначным!");
}
else if (number >= 1000 && number <= 1000000000)
{
Console.WriteLine("Ошибка число не является трехзначным!");
}
else
{
Console.WriteLine($"Вторая цифра из {number} -> {digit3}");
}