// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// Например
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
 
Console.Write("Введите натуральное число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int num = SumDigit(numberA, numberB);
Console.WriteLine($"Число {numberA} в степени {numberB} = {num}");

int SumDigit(int numberA, int numberB)
{
    int result = 1;
    for(int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}
