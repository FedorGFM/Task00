// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int FactorialRec(int n)
// {
// if (n == 1) return 1;
// else return n * FactorialRec(n - 1);
// }


Console.Write("Введите натуральное число M: ");
int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(SumDigit(number));

int SumDigit(int num)
{
    if(num == 0) return num;
    else return num % 10 + SumDigit(num / 10);
}