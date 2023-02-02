// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите натуральное число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int FunctionAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return FunctionAkkerman(m - 1, 1);
    return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
}
System.Console.Write("A(m, n) = ");
System.Console.Write(FunctionAkkerman(numberM, numberN));
