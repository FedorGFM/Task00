// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// Например
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int countNumbers = CountNumbers(number);
Console.Write($"количество цифр в числе = {countNumbers}");

int CountNumbers(int digit)
{
    int count = 0;

    while (digit != 0)
    {
        digit = digit / 10;
        count = count + 1;
    }
    return count;
}