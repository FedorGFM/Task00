﻿// Напишите программу, которая 
// 1. выводит случайное число из отрезка [10, 99] и 
// 2. показывает наибольшую цифру числа.
// Например
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10-99 => {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

// if (firstDigit > secondDigit) 
// {
//     Console.WriteLine($"Наибольшая цифра числа => {firstDigit}");
// }
// else 
// {
//     Console.WriteLine($"Наибольшая цифра числа => {secondDigit}");
// }

// Console.Write($"Наибольшая цифра числа => ");
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);

//  int result = firstDigit > secondDigit ? firstDigit : secondDigit;
//  Console.Write($"Наибольшая цифра числа => {result}");

// int maxDigit = MaxDigit(number);
// Console.Write($"Наибольшая цифра числа => {maxDigit}");

// int MaxDigit(int number)
// {
//     int firstDigit = number / 10;
//     int secondDigit = number % 10;
//     int result = firstDigit > secondDigit ? firstDigit : secondDigit;
//     return result;
// }

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit}");

int maxDigit1 = MaxDigit(45);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit1}");

int maxDigit2 = MaxDigit(78);
Console.WriteLine($"Наибольшая цифра числа => {maxDigit2}");

int MaxDigit(int num) // num = number
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int result = firstDigit > secondDigit ? firstDigit : secondDigit;
    return result;
}