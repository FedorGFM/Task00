// Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.
// Пример
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number  = Convert.ToInt32(Console.ReadLine());

Console.Write($"В числе {number} -> ");

if (number < 0) number  *= -1;
if (number <=99 & number >= -99) Console.Write("Третьей цифры нет");
else Console.Write(SecondNumber(number));

int SecondNumber(int number)
{
    while (number >= 999) number /= 10;
    return number % 10;
}