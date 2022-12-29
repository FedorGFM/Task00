// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Например
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите число: ");
string number = Console.ReadLine();

void NumberPalindrome(string number)
{
    if(number [0] == number [4] && number [1] == number [3])
    {
    Console.WriteLine($"Число: {number} -> Палиндром.");
    }
    else Console.WriteLine($"Число: {number} -> Не палиндром.");
}

if (number.Length == 5)
{
    NumberPalindrome(number);
} 
else Console.WriteLine("Неверное число");