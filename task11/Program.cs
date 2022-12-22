// . Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Например
// 456 -> 46
// 782 -> 72
// 918 -> 98

// Мое решение 

// int number = new Random().Next(100, 1000);
// Console.WriteLine($"Случайное трехзначное число из отрезка 100-999 => {number}");

// int firstDigit = number / 100;
// int secondDigit = number % 10;

// if (number >= 100 && number <= 999)
// Console.WriteLine($"->{firstDigit}{number % 10}");

// Решение в группах на семинаре

int number = new Random().Next(100, 1000);

int firstDigit = number / 100;
int thirdDigit = number % 10;

int result = firstDigit * 10 + thirdDigit;
Console.WriteLine($"Результат из {number} -> {result}");