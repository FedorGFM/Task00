// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5},");
            else Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine("]");
    }
}

Random rnd = new Random();
int rows = rnd.Next(1, 10);
int columns = rnd.Next(1, 10);

int[,] array2D = CreateMatrixRndInt(rows, columns, -99, 99);
PrintMatrix(array2D);

Console.WriteLine("Введите номер строки и столбца. Счетчик начинается c 1:");
Console.Write("Ряд= ");
int rowsPos = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбец = ");
int columnsPos = Convert.ToInt32(Console.ReadLine());
Console.Write($"{rowsPos}, {columnsPos} -> ");

if (rowsPos <= rows && columnsPos <= columns && rowsPos > 0 && columnsPos > 0)
{
    Console.Write(array2D[rowsPos - 1, columnsPos - 1]);
}
else if (rowsPos <= 0) Console.WriteLine("Такого ряда нет.");
else if (columnsPos <= 0) Console.WriteLine("Такого столбца нет.");
else if (rowsPos > rows || columnsPos > columns) Console.WriteLine("Такого элемента в массиве нет.");