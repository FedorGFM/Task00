//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Например
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    TableCube(number);
}

else System.Console.WriteLine("Не натуральное число");

void TableCube(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count} в кубе будет -> {Math.Pow(count, 3), 4}");  // Цифры 4 делают отступ и выравнивание по правой стороне
        //Console.WriteLine($"{count}\t" + Math.Pow(count, 2)); можно так через табуляцию
        count ++;
    }
}