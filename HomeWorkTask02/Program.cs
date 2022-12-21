// Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// Пример
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;

if (firstNumber > max) max = firstNumber; 
if (secondNumber > max) max = secondNumber;

Console.Write("Max = ");
Console.Write(max);