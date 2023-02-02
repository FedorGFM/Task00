﻿// *Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrix(int size, int min)
{
    int[,] matrix = new int[size, min];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}   ");
        }
        Console.WriteLine();
    }
}

Console.Write("Ведите размер спирали: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите размер спирали: ");
int min = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrix(size, min);
PrintMatrix(array2D);