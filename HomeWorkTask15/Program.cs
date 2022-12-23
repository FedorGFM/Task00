// Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// Например
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру соответствующую дню недели: ");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay >= 1 && numberDay <= 7)
{
    if (Day(numberDay)) 
    {
    Console.WriteLine("Выходной");
    }
    else Console.WriteLine("Будни");
}

else Console.WriteLine("Такого дня недели нет");

bool Day(int num)
{
    return num == 6 || num == 7;
}