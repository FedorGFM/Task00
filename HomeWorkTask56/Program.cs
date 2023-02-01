// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}   ");
        }
        Console.WriteLine("]");
    }
}

void SumMinNumbersInLengthMatrix(int[,] matrix)
{
    int sumMin = 0;
    // int count = 1;
    // int sum = 0;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sumMin += matrix[0, i];
    }
    
    int count = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        // Console.WriteLine($"Сумма минимальных чисел -> {sum}.");      //Для удобства и наглядности
        if (sumMin > sum)
        {
            sumMin = sum;
            count = i + 1;
        }
    }
    Console.WriteLine();   
    Console.WriteLine($"Строка с наименьшей суммой элементов в строке -> {count}.");
    Console.WriteLine($"Сумма чисел в строке {count} = {sumMin}.");
}

Random rnd = new Random();
int rows = rnd.Next(1, 11);
int columns = rnd.Next(1, 11);

int[,] array2D = CreateMatrix(rows, columns, 0, 10);
PrintMatrix(array2D);
SumMinNumbersInLengthMatrix(array2D);
