// Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// Например
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// if number <= 0 

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {sumNumbers}");

int SumNumbers(int num)
{ 
    int sum = 1;

    for (int i = 1; i <= num; i++)
    {
        checked
        {
            sum *= i;
        }
    }
    return sum;
}