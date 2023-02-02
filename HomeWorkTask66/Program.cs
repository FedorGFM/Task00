// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число A: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int count = SumNumber(numberM, numberN);
if(numberM <= 0 && numberN <= 0) System.Console.WriteLine($"{numberM} Ненатуральное число.");

else System.Console.WriteLine(count);

int SumNumber(int numM, int numN)
{
    if (numM == numN) return numM;
    if (numM < numN) return numN + SumNumber(numM, numN - 1);
    return numM + SumNumber(numM - 1, numN);
}
