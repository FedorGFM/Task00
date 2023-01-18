// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// Например
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int countNumbers = CountNumbers(number);
Console.Write($"Сумма цифр числа {number} = {countNumbers}");

int CountNumbers(int number)
{
    int counter = Convert.ToString(number).Length;
    int count = 0;
    int result =0;

    for (int i = 0; i < counter; i++)
    {
        count = number - number % 10;
        result = result + (number - count);
        number = number / 10;
    }
    return result;
}