//  Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).

Console.Write("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) Console.Write("Yes");

else if (number % 2 > 0) Console.Write("No");

else if (number % 2 < 0) Console.Write("No");