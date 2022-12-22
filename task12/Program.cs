// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.

// Например
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// bool result = firstNumber % secondNumber == 0;

// if (result) Console.WriteLine("Кратно ");
// else Console.WriteLine($"Не кратно, остаток: {firstNumber % secondNumber}");

// Второе решение методом

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = Multiplicity(number1, number2);
Console.WriteLine(result == 0 ? "Кратно " : $"Не кратно, остаток от деления {result}");

int Multiplicity(int num1, int num2)
{
    return num1 % num2;
}