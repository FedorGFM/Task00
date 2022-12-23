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

Console.WriteLine($"Результат из {number} -> {digit3}");
